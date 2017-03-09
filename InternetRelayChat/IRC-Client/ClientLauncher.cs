using IRC_Client.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
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
            string configFile = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;
            RemotingConfiguration.Configure(configFile, false);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
