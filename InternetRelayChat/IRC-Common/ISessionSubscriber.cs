using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRC_Common
{
    [Serializable]
    public abstract class ISessionSubscriber : MarshalByRefObject
    {
        public void Handle(string str)
        {
            InternalHandler(str);
        }

        protected abstract void InternalHandler(string str);
    }
}
