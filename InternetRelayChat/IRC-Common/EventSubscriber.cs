using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRC_Common
{
    [Serializable]
    public class EventSubscriber : MarshalByRefObject
    {
        [Serializable]
        public enum EventType
        {
            SESSION_UPDATE
        }

        private IClient client { get; set; }
        private EventType type { get; }

        public EventSubscriber(IClient client, EventType type)
        {
            this.client = client;
            this.type = type;
        }

        public void HandleEvent(SessionUpdateArgs info)
        {
            switch(type)
            {
                case EventType.SESSION_UPDATE:
                    client.HandleSessionUpdate(info);
                    break;
            }
        }
    }
}
