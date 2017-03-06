using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRC_Common
{
    [Serializable]
    public delegate void SessionUpdateHandler(SessionUpdateArgs info);

    public interface IServer
    {
        event SessionUpdateHandler SessionUpdateEvent;

        bool Login(string nickname, string password, string ip, int port);

        int Register(string nickname, string realName, string password);

        bool Logout(string nickname, string password);

        List<LoggedUserInfo> LoggedUsers(string nickname);
    }
}
