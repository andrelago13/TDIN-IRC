using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace IRC_Server
{
    public class Server
    {
        public static void Main(string[] args)
        {
            // Create database
            if (!Directory.Exists("res/database.sqlite"))
            {
                Directory.CreateDirectory("res");
                SQLiteConnection.CreateFile("res/database.sqlite");

                //TODO: Create database script
            }

            Console.WriteLine("Server started.");
            // Configure remote objects
            string configFile = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;
            RemotingConfiguration.Configure(configFile, false);

            RemotingConfiguration.RegisterWellKnownServiceType(
               typeof(Login), "Login",
               WellKnownObjectMode.Singleton);

            Console.ReadKey();
            Console.WriteLine("Server ended.");
        }
    }
}
