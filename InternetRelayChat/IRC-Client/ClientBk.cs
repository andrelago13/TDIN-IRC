using IRC_Common;
using System;

namespace IRC_Client
{
    [Serializable]
    public class ClientBk : IClient
    {
        private static ClientBk instance;

        public static ClientBk Instance
        {
            get
            {
                if (instance == null)
                    instance = new ClientBk();
                return instance;
            }
        }

        private LoggedUserInfo myUser;
        private SessionsEventSubscriber sessionSubscriber;

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
                    //this.connection = (IServer)Activator.GetObject(typeof(IServer), "tcp://" + this.ServerAddress + ":" + this.ServerPort + "/IRC-Server/Server");
                    sessionSubscriber = new SessionsEventSubscriber(this);
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
            bool result = connection.Login(nick, password, "", 0);

            if(result)
            {
                myUser = new LoggedUserInfo(nick, null, null, 0);
                connection.SessionUpdateEvent += sessionSubscriber.Handler;
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
                    connection.SessionUpdateEvent -= sessionSubscriber.Handler;
                }
                return result;
            }
            return false;
        }
    }
}
