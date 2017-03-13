using IRC_Common;
using System;

namespace IRC_Client
{
    [Serializable]
    public class Client : MarshalByRefObject, IClient
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
                }
                return this.connection;
            }
        }
        #endregion

        public void HandleSessionUpdate(SessionUpdateArgs info)
        {

        }

        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
}
