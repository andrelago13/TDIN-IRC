using IRC_Client.ViewModels;
using IRC_Common;
using System;
using System.Runtime.Remoting;

namespace IRC_Client
{
    [Serializable]
    public class Client : IClient
    {
        #region singleton

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

        #region private_fields

        private LoggedUserInfo myUser;
        private SessionSubscriber sessionSubscriber;

        #endregion

        #region Server connection

        private IServer connection;

        public string ServerAddress { get; set; }

        public int ServerPort { get; set; }

        public IServer Connection
        {
            get
            {
                if (this.connection == null)
                {
                    connection = (IServer)Activator.GetObject(typeof(IServer), "tcp://" + LoginViewModel.Instance.ServerAddress + ":" + LoginViewModel.Instance.ServerPort + "/IRC-Server/Server");
                }
                return this.connection;
            }
        }

        public override object InitializeLifetimeService()
        {
            return null;
        }

        #endregion

        #region public_methods

        public Client()
        {
            sessionSubscriber = new SessionSubscriber(this);
        }

        public bool Login(string nick, string password)
        {
            //TODO: assign ip and port of connector
            bool result = Connection.Login(nick, password, "", 0);

            if (result)
            {
                myUser = new LoggedUserInfo(nick, null, null, 0);

                RemotingConfiguration.RegisterWellKnownServiceType(typeof(SessionSubscriber),
                "IRC-Client/ServerEvents", WellKnownObjectMode.Singleton);

                Connection.SessionUpdateEvent += sessionSubscriber.Handle;
            }

            return result;
        }

        public bool MaybeLogout(string password)
        {
            if (connection != null && myUser != null)
            {
                bool result = connection.Logout(myUser.Nickname, password);
                if (result)
                {
                    myUser = null;
                }
                return result;
            }
            return false;
        }

        public LoggedUserInfo LoggedUser
        {
            get
            {
                return myUser;
            }
        }

        #endregion
    }
}
