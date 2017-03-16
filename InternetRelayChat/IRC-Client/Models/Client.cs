using IRC_Client.Comunication;
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

        #endregion

        #region Accessors
        public string Password { get; set; }

        public ServerConnection ServerConnection { get; set; }
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

        public bool InviteClient(string address, int port)
        {
            PeerCommunicatorContainer pc = (PeerCommunicatorContainer)Activator.GetObject(
                typeof(PeerCommunicatorContainer), "tcp://" + address + ":" + port + "/IRC-Client/PeerCommunicatorContainer");
            return pc.GetCommunicator().RequestChat(this);
        }

        public bool HandleInvite(Client requestingClient)
        {
            var confirmResult = MessageBox.Show(requestingClient.RealName + " (" + requestingClient.Nickname +
                ") invited you to chat. Do you want accept his invite?", "Chat invite",
                                     MessageBoxButtons.YesNo);
            return confirmResult == DialogResult.Yes;
        }

        public void ReceiveMessage(Client sender, string message)
        {
            //TODO
        }

        private void SetupPeerCommunicator()
        {
            MyPeerCommunicator = new PeerCommunicator(this);

            PeerCommunicatorContainer.Communicator = MyPeerCommunicator;
            RemotingConfiguration.RegisterWellKnownServiceType(new PeerCommunicatorContainer().GetType(),
                "IRC-Client/PeerCommunicatorContainer", WellKnownObjectMode.Singleton);
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

            return connection.Logout(this.Nickname, this.Password);
        }

        #endregion
    }
}
