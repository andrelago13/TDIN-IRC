using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRC_Client.Models
{
    class Login
    {
        public string Nickname { get; set; }

        public string Password { get; set; }

        public string ServerAddress { get; set; }

        public int ServerPort { get; set; }
    }
}
