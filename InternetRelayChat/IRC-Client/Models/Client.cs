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

        private Client()
        {
            this.ServerConnection = new Connection();
            this.SessionEvent = new SessionSubscriber(Client.Instance);
        }

        #region Accessors
        public string Nickname { get; set; }

        public string Password { get; set; }

        public string RealName { get; set; }

        public Connection ServerConnection { get; set; }
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
    }
}
