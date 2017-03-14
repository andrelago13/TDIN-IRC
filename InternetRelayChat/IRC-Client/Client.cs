using IRC_Client.ViewModels;
using IRC_Common;
using System;
using System.Runtime.Remoting;

namespace IRC_Client
{
    [Serializable]
    public class Client : IClient
    {
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

        private LoggedUserInfo myUser;

        public LoggedUserInfo LoggedUser
        {
            get
            {
                return myUser;
            }
        }

        #region Server connection
        private IServer connection;

        public string ServerAddress { get; set; }

        public int ServerPort { get; set; }

        public IServer Connection
        {
            get
            {
                if(this.connection == null)
                {
                    connection = (IServer)Activator.GetObject(typeof(IServer), "tcp://" + LoginViewModel.Instance.ServerAddress + ":" + LoginViewModel.Instance.ServerPort + "/IRC-Server/Server");
                }
                return this.connection;
            }
        }
        #endregion

        public override object InitializeLifetimeService()
        {
            return null;
        }

        public bool Login(string nick, string password)
        {
            //TODO: assign ip and port of connector
            bool result = Connection.Login(nick, password, "", 0);

            if(result)
            {
                myUser = new LoggedUserInfo(nick, null, null, 0);

                RemotingConfiguration.RegisterWellKnownServiceType(typeof(SessionSubscriber),
                "ServerEvents", WellKnownObjectMode.Singleton);

                SessionSubscriber sink = new SessionSubscriber();
                Connection.SessionUpdateEvent += new SessionUpdateHandler(sink.Handle);
            }

            return result;
        }

        public bool MaybeLogout(string password)
        {
            if(connection != null && myUser != null)
            {
                bool result = connection.Logout(myUser.Nickname, password);
                if(result)
                {
                    myUser = null;
                }
                return result;
            }
            return false;
        }
    }
}
