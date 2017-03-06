using IRC_Client.GUI;
using IRC_Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRC_Client
{
    [Serializable]
    public class Client : MarshalByRefObject, IClient
    {
        public static void Main(string[] args)
        {
            Client c = new Client();
            c.LaunchGUI();
        }

        public Client() { }

        public void LaunchGUI()
        {
            Console.WriteLine("Client started.");

            string configFile = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;
            RemotingConfiguration.Configure(configFile, false);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
        
        public void HandleSessionUpdate(SessionUpdateArgs info)
        {

        }
    }
}
