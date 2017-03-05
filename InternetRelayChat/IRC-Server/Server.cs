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
    public class Server
    {
        public static void Main(string[] args)
        {
            SQLiteConnection conn = InitializeDatabase("data", "database.sqlite");

            Console.WriteLine("Server started.");
            SetupServer();
            Console.Write("Press any key to terminate... ");
            Console.ReadKey();
            Console.WriteLine("Server ended.");
        }

        private static SQLiteConnection InitializeDatabase(string dbDir, string dbFile)
        {
            string fullPath = dbDir + "/" + dbFile;
            bool needsInitializing = false;

            // Create database
            if (!File.Exists(fullPath))
            {
                Console.WriteLine(fullPath);
                Directory.CreateDirectory(dbDir);
                SQLiteConnection.CreateFile(fullPath);
                needsInitializing = true;
            }

            // Connect to database
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + fullPath + "; Version=3;");
            conn.Open();

            if (needsInitializing)
            {
                ConfigureDatabase(conn);
            }

            return conn;
        }

        private static void ConfigureDatabase(SQLiteConnection conn)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            StreamReader textStreamReader = new StreamReader("resources/db_init.txt");

            // Read commands from resource file
            while(textStreamReader.Peek() != -1)
            {
                string line = textStreamReader.ReadLine();
                SQLiteCommand command = new SQLiteCommand(line, conn);
                command.ExecuteNonQuery();
            }            
        }

        private static void TerminateDatabase(SQLiteConnection conn)
        {
            conn.Close();
            conn.Dispose();
        }

        private static void SetupServer()
        {
            // Configure remote objects
            string configFile = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;
            RemotingConfiguration.Configure(configFile, false);

            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Login), "Login", WellKnownObjectMode.Singleton);
        }
    }
}
