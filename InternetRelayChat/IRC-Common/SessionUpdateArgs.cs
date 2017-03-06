using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRC_Common
{
    public class SessionUpdateArgs
    {
        public string Username;
        public string IP;
        public int Port;
        public bool LoggedIn; // true if user logged in, false if he logged out

        public SessionUpdateArgs(string user, string ip, int port)
        {
            Username = user;
            IP = ip;
            Port = port;
        }
    }
}
