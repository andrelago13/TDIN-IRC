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
        private ClientBk client;

        public ClientBk MyClient
        {
            get
            {
                return client;
            }
            
            set
            {
                client = value;
            }
        }

        public SessionSubscriber(ClientBk c)
        {
            client = c;
        }

        protected override void InternalHandler(string str)
        {
            Console.WriteLine("Your message in callback 2");
        }
    }
}
