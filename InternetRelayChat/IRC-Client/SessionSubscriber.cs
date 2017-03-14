using IRC_Client.Models;
using IRC_Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRC_Client
{
    [Serializable]
    public class SessionSubscriber : ISessionSubscriber
    {
        public Client Client { get; set; }

        public SessionSubscriber(Client Client)
        {
            this.Client = Client;
        }

        protected override void InternalHandler(SessionUpdateArgs info)
        {
            this.Client.HandleSession(info);
        }
    }
}
