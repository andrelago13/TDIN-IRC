using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRC_Common
{
    public interface ILogin
    {
        bool Login(string username, string password);

        int Register(string username, string realName, string password);
    }
}
