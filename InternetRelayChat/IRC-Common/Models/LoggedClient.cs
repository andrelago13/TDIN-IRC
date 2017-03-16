using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRC_Common.Models
{
    [Serializable]
    public class LoggedClient : IClient
    {
        public LoggedClient(string nickname) : base(nickname) { }

        public LoggedClient(string nickname, string realname, string address, int port)
            : base(nickname, realname, address, port) { }
    }
}
