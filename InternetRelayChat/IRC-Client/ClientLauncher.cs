using IRC_Client.Models;
using IRC_Client.Views;
using IRC_Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRC_Client
{
    class ClientLauncher
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting the client...");

            LaunchGUI();
        }

        private static void LaunchGUI()
        {
            BinaryServerFormatterSinkProvider provider = new BinaryServerFormatterSinkProvider();
            provider.TypeFilterLevel = TypeFilterLevel.Full;
            IDictionary props = new Hashtable();
            int port = Utils.GetFreeTcpPort();
            Client.Instance.Port = port;
            props["port"] = port;
            TcpChannel chan = new TcpChannel(props, null, provider);
            ChannelServices.RegisterChannel(chan, false);
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainView());
        }
    }
}
