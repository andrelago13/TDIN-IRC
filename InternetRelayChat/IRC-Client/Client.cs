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

            IServer loginService = (IServer) Activator.GetObject(typeof(IServer), "tcp://localhost:35994/IRC-Server/Server");

            Console.WriteLine(loginService.Register("admin", "Administrator", "1234"));
            Console.WriteLine(loginService.Login("admin", "1234", "127.0.0.1", 35994));

            Console.WriteLine("Press any key to logout.");
            Console.ReadKey();
            Console.WriteLine(loginService.Logout("admin", "1234"));
            Console.WriteLine("Client ended.");
        }
    }
}
