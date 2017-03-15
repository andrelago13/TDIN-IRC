using IRC_Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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

        private Client() : base(null)
        {
            this.ServerConnection = new ServerConnection();
            this.SessionEvent = new SessionSubscriber(this);
        }

        #region Accessors
        public string Password { get; set; }

        public ServerConnection ServerConnection { get; set; }
        #endregion

        #region Session Subscriber
        private SessionSubscriber SessionEvent;

        public event SessionUpdateHandler SessionsEvent;

        public void HandleSession(SessionUpdateArgs info)
        {
            if (SessionsEvent != null)
            {
                SessionsEvent(info);
            }
        }
        #endregion

        #region Authentication Methods
        public bool Login(string nick, string password)
        {
            //TODO: assign ip and port of connector
            IServer connection = ServerConnection.Connection;
            if (connection == null)
                return false;
            int port = Utils.GetFreeTcpPort();
            string ip = Utils.GetIp();

            bool result = connection.Login(nick, password, ip, port);
            if (result)
            {
                this.Nickname = nick;
                this.Address = ip;
                this.Port = port;
                connection.SessionUpdateEvent += SessionEvent.Handle;
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
