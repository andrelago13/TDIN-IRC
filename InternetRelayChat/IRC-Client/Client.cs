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
            //c.Run();
            c.LaunchGUI();
        }

        public Client() { }

        public void Run()
        {
            Console.WriteLine("Client started.");

            string configFile = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;
            RemotingConfiguration.Configure(configFile, false);

            IServer loginService = (IServer)Activator.GetObject(typeof(IServer), "tcp://localhost:35994/IRC-Server/Server");

            Console.WriteLine(loginService.Register("admin", "Administrator", "1234"));
            Console.WriteLine(loginService.Login("admin", "1234", "127.0.0.1", 35994));
            List<LoggedUserInfo> l = loginService.LoggedUsers("admin");
            Console.WriteLine(l.Count);
            if(l.Count > 0)
            {
                LoggedUserInfo i = l[0];
                Console.WriteLine(i.Nickname + " " + i.RealName + " " + i.IP + " " + i.Port);
            }

            //loginService.SessionUpdateEvent += new SessionUpdateHandler(HandleSessionUpdate);

            Console.WriteLine("Press any key to logout.");
            Console.ReadKey();
            Console.WriteLine(loginService.Logout("admin", "1234"));
            Console.WriteLine("Client ended.");
        }

        public void LaunchGUI()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
        
        public void HandleSessionUpdate(SessionUpdateArgs info)
        {

        }
    }
}
