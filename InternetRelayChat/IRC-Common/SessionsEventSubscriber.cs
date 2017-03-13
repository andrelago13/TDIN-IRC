using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRC_Common
{
    [Serializable]
    public class SessionsEventSubscriber : MarshalByRefObject
    {
        private IClient client { get; set; }

        public SessionsEventSubscriber(IClient client)
        {
            this.client = client;
        }

        public void Handler(SessionUpdateArgs info)
        {
            client.HandleSession(info);
        }
    }
}
