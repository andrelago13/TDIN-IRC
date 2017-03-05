using IRC_Common;
using System;
using System.Data.SQLite;
using System.IO;
using System.Reflection;

namespace IRC_Server
{
    class Server : MarshalByRefObject, IServer
    {
        public Server()
        {
            SQLiteConnection conn = InitializeDatabase("data", "database.sqlite");
        }

        public int Register(string username, string realName, string password)
        {
            Random rnd = new Random();
            return rnd.Next(1, 13);
        }

        bool IServer.Login(string username, string password)
        {
            return true;
        }

        private SQLiteConnection InitializeDatabase(string dbDir, string dbFile)
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

        private void ConfigureDatabase(SQLiteConnection conn)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            StreamReader textStreamReader = new StreamReader("resources/db_init.txt");

            // Read commands from resource file
            while (textStreamReader.Peek() != -1)
            {
                string line = textStreamReader.ReadLine();
                SQLiteCommand command = new SQLiteCommand(line, conn);
                command.ExecuteNonQuery();
            }
        }

        private void TerminateDatabase(SQLiteConnection conn)
        {
            conn.Close();
            conn.Dispose();
        }
    }
}
