using IRC_Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace IRC_Server
{
    public class ServerLauncher
    {
        public static void Main(string[] args)
        {
            SetupServer();
            Console.WriteLine("Press any key to terminate... ");
            Console.ReadKey();
            Console.WriteLine("Server ended.");
        }

        private static void SetupServer()
        {
            BinaryServerFormatterSinkProvider provider = new BinaryServerFormatterSinkProvider();
            provider.TypeFilterLevel = TypeFilterLevel.Full;
            IDictionary props = new Hashtable();
            int port = 35994;
            props["port"] = port;
            TcpChannel chan = new TcpChannel(props, null, provider);

            ChannelServices.RegisterChannel(chan, false);

            RemotingConfiguration.RegisterWellKnownServiceType(new Server().GetType(),
                "IRC-Server/Server", WellKnownObjectMode.Singleton);

            Console.WriteLine("Server started on " + Utils.GetLocalIp() + ":" + port);
        }
    }
}
