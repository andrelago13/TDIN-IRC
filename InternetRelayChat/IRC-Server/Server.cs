using IRC_Common;
using System;
using System.Data.SQLite;
using System.IO;
using System.Reflection;

namespace IRC_Server
{
    class Server : MarshalByRefObject, IServer
    {
        private SQLiteConnection conn;

        public Server()
        {
            conn = InitializeDatabase("data", "database.sqlite");
        }

        // PUBLIC/API METHODS /////////////////////////////////////////////////

        /*
         * Returns 0 upon success
         * Error codes:
         * (-1) - database error
         * (1) - invalid username
         * (2) - invalid real name
         * (3) - invalid password
         * (4) - username already exists
         */
        public int Register(string username, string realName, string password)
        {
            if(username.Length < 1)
            {
                return 1;
            }

            if(realName.Length < 1)
            {
                return 2;
            }

            if(password.Length < 1)
            {
                return 3;
            }

            if(DBController.UserExists(conn, username))
            {
                return 4;
            }

            if(!DBController.CreateUser(conn, username, realName, password))
            {
                return -1;
            }

            return 0;
        }

        public bool Login(string username, string password)
        {
            bool loggedIn = DBController.PasswordMatch(conn, username, password);
            //TODO: start heartbeat connection with client
            return loggedIn;
        }

        // PRIVATE METHODS ////////////////////////////////////////////////////

        private SQLiteConnection InitializeDatabase(string dbDir, string dbFile)
        {
            string fullPath = dbDir + "/" + dbFile;
            bool needsInitializing = false;

            // Create database
            if (!File.Exists(fullPath))
            {
                Console.WriteLine("Creating database");
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

            // Close the connection so that it is only opened upon client requests
            conn.Close();
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
