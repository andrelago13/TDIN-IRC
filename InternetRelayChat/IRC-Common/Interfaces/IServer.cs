using IRC_Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRC_Common
{
    [Serializable]
    public delegate void SessionUpdateHandler(SessionUpdateArgs info);

    public abstract class IServer : MarshalByRefObject
    {
        public abstract event SessionUpdateHandler SessionUpdateEvent;

        public abstract bool Login(string nickname, string password, string ip, int port);

        public abstract int Register(string nickname, string realName, string password);

        public abstract bool Logout(string nickname, string password);

        public abstract List<LoggedClient> LoggedUsers(string nickname);
    }
}
