using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRC_Common.Models
{
    public class LoggedClient : IClient
    {
        public LoggedClient(string nickname, string name, string address, int port) : base(nickname, name, address, port)
        {
        }

        public override bool HandleInvite(IClient requestingClient)
        {
            return false;
        }

        public override void ReceiveMessage(IClient sender, string message)
        {
        }
    }
}
