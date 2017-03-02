using IRC_Common;
using System;

namespace IRC_Server
{
    class Login : MarshalByRefObject, ILogin
    {
        public int Register(string username, string realName, string password)
        {
            Random rnd = new Random();
            return rnd.Next(1, 13);
        }

        bool ILogin.Login(string username, string password)
        {
            return true;
        }
    }
}
