using IRC_Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace IRC_Client
{
    class Client
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Client started.");

            string configFile = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;
            RemotingConfiguration.Configure(configFile, false);

            ILogin loginService = (ILogin) Activator.GetObject(typeof(ILogin), "tcp://localhost:35994/IRC-Server/Login");

            Console.WriteLine(loginService.Register("", "", ""));

            Console.WriteLine("Press any key to end.");
            Console.ReadKey();
            Console.WriteLine("Client ended.");
        }
    }
}
