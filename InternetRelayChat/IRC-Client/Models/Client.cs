using IRC_Client.Comunication;
using IRC_Client.Views;
using IRC_Common;
using IRC_Common.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRC_Client.Models
{
    public class Client : IClient
    {
        #region Singleton
        private static Client instance;

        public static Client Instance
        {
            get
            {
                if (instance == null)
                    instance = new Client();
                return instance;
            }
        }
        #endregion

        #region Private Methods

        private Client() : base(null)
        {
            this.ServerConnection = new ServerConnection();
            this.SessionSessionEvent = new SessionSubscriber(this);
        }

        private async void GetName()
        {
            string res = await Task.Run(() => ServerConnection.Connection.GetUserRealName(Nickname));
            this.RealName = res;
        }

        #endregion

        #region Accessors

        public string Password { get; set; }

        public ServerConnection ServerConnection { get; set; }

        public Dictionary<string, LoggedClient> LoggedClients { get; }

        #endregion

        #region Session Subscriber

        private SessionSubscriber SessionSessionEvent;

        public event SessionUpdateHandler SessionsEvent;

        public void HandleSession(LoggedClient info)
        {
            if (SessionsEvent != null)
            {
                SessionsEvent(info);
            }
        }

        #endregion

        #region PeerToPeer

        private PeerCommunicator MyPeerCommunicator;
        public event HandleMessage MessageEvent;
        public event HandleChat NewChatEvent;
        private Dictionary<string, PeerCommunicator> peers = new Dictionary<string, PeerCommunicator>();

        public bool InviteClient(LoggedClient client)
        {
            if (client == null)
                return false;

            PeerCommunicator pc = GetClientCommunicator(client.Address, client.Port);
            bool result = pc.RequestChat(this);
            if(result)
            {
                peers.Add(client.Nickname, pc);
                NewChatEvent?.Invoke(client);
            }
            return result;
        }

        public bool HandleInvite(Client requestingClient)
        {
            var confirmResult = MessageBox.Show(requestingClient.RealName + " [" + requestingClient.Nickname +
                "] invited you to chat. Do you want accept his invite?", "Chat invite",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                peers.Add(requestingClient.Nickname, GetClientCommunicator(requestingClient));
                NewChatEvent?.Invoke(requestingClient);
                return true;
            }

            return false;
        }

        public void ReceiveMessage(Client sender, string message)
        {
            MessageEvent?.Invoke(sender, message);
        }

        private void SetupPeerCommunicator()
        {
            MyPeerCommunicator = new PeerCommunicator(this);

            PeerCommunicatorContainer.Communicator = MyPeerCommunicator;
            RemotingConfiguration.RegisterWellKnownServiceType(new PeerCommunicatorContainer().GetType(),
                "IRC-Client/PeerCommunicatorContainer", WellKnownObjectMode.Singleton);
        }

        private bool SendMessage(string nickname, string message)
        {
            PeerCommunicator comm = null;
            if (!peers.TryGetValue(nickname, out comm))
                return false;

            try
            {
                comm.SendMessage(this, message);
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            return true;
        }

        public PeerCommunicator GetClientCommunicator(IClient client)
        {
            return GetClientCommunicator(client.Address, client.Port);
        }

        private PeerCommunicator GetClientCommunicator(string address, int port)
        {
            PeerCommunicatorContainer pc = (PeerCommunicatorContainer)Activator.GetObject(
                typeof(PeerCommunicatorContainer), "tcp://" + address + ":" + port + "/IRC-Client/PeerCommunicatorContainer");
            return pc.GetCommunicator();
        }

        public void EndCommunication(string nickname)
        {
            peers.Remove(nickname);
        }

        #endregion

        #region Authentication Methods

        public bool Login(string nick, string password)
        {
            IServer connection = ServerConnection.Connection;
            if (connection == null)
                return false;
            string ip = Utils.GetLocalIp();

            bool result = connection.Login(nick, password, ip, Port);
            if (result)
            {
                this.Nickname = nick;
                this.Address = ip;
                GetName();
                connection.SessionUpdateEvent += SessionSessionEvent.Handle;
                SetupPeerCommunicator();
            }

            return result;
        }

        public bool MaybeLogout()
        {
            if (ServerConnection == null)
                return false;

            IServer connection = ServerConnection.Connection;
            if (connection == null)
                return false;
            
            connection.SessionUpdateEvent -= SessionSessionEvent.Handle;

            return connection.Logout(this.Nickname, this.Password);
        }

        #endregion
    }
}
