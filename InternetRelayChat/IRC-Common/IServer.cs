using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRC_Common
{
    public interface IServer
    {
        bool Login(string username, string password, string ip, int port);

        int Register(string username, string realName, string password);

        bool Logout(string username, string password);
    }
}
