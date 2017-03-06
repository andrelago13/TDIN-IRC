using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRC_Common
{
    public class Utils
    {
        public static readonly Dictionary<int, string> ErrorCodes = new Dictionary<int, string>()
        {
            { -1, "Database Error" },
            { 0, "Success" },
            { 1, "Invalid nickname" },
            { 2, "Invalid real name" },
            { 3, "Invalid password" },
            { 4, "Username already exists" }
        };
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
