using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRC_Common
{
    public abstract class IClient : MarshalByRefObject
    {
        public string Nickname { get; set; }

        public string RealName { get; set; }
    }
}
