using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IRC_Client.Models
{
    class Client
    {
        private static Client instance;

        public static Client Instance
        {
            get
            {
                if (instance == null)
                    instance = new Client();
                return instance;
            }
        }

        private Client()
        {
            this.ServerConnection = new Connection();
        }

        public string Nickname { get; set; }

        public string Password { get; set; }

        public string RealName { get; set; }

        public Connection ServerConnection { get; set; }
    }
}
