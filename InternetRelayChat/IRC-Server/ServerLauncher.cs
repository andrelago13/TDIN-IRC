using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace IRC_Server
{
    public class ServerLauncher
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Server started.");
            SetupServer();
            Console.Write("Press any key to terminate... ");
            Console.ReadKey();
            Console.WriteLine("Server ended.");
        }

        private static void SetupServer()
        {
            // Configure remote objects
            string configFile = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;
            RemotingConfiguration.Configure(configFile, false);

            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Server), "Login", WellKnownObjectMode.Singleton);
        }
    }
}
