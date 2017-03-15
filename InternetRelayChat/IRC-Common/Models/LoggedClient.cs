using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRC_Common.Models
{
    public class LoggedClient : IClient
    {
        #region Accessors
        public string Address { get; set; }

        public int Port { get; set; }
        #endregion

        public LoggedClient(string nickname, string realName, string address, int port)
        {
            this.Nickname = nickname;
            this.RealName = realName;
            this.Address = address;
            this.Port = port;
        }
    }
}
