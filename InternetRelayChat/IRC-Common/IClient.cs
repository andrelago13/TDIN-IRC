using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRC_Common
{
    public abstract class IClient : MarshalByRefObject
    {
        public event SessionUpdateHandler sessionsEvent;

        public void HandleSession(SessionUpdateArgs info)
        {
            if(sessionsEvent != null)
            {
                sessionsEvent(info);
            }
        }
    }
}
