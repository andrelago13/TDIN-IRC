using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRC_Common
{
    public class Utils
    {
    }

    [Serializable]
    public class LoggedUserInfo
    {
        private string nickname;
        private string realName;
        private string ip;
        private int port;

        public string Nickname
        {
            get
            {
                return nickname;
            }

            set
            {
                nickname = value;
            }
        }

        public string RealName
        {
            get
            {
                return realName;
            }

            set
            {
                realName = value;
            }
        }

        public string IP
        {
            get
            {
                return ip;
            }

            set
            {
                ip = value;
            }
        }

        public int Port
        {
            get
            {
                return port;
            }

            set
            {
                port = value;
            }
        }

        public LoggedUserInfo(string nick, string name, string ip, int port)
        {
            nickname = nick;
            realName = name;
            this.ip = ip;
            this.port = port;
        }
    }
}
