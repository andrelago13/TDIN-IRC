using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
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
            ChannelServices.RegisterChannel(new TcpChannel(35994), false);

            RemotingConfiguration.RegisterWellKnownServiceType(new Server().GetType(),
                "IRC-Server/Server", WellKnownObjectMode.Singleton);
        }
    }
}
