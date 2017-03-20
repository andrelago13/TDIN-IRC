using IRC_Common;
using IRC_Common.Models;
using IRC_Server.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Reflection;

namespace IRC_Server
{
    class Server : IServer
    {
        private SQLiteConnection conn;

        public event SessionUpdateHandler MyHandler;
        public override event SessionUpdateHandler SessionUpdateEvent
        {
            add
            {
                Console.WriteLine("SessionUpdateEvent subscriber added");
                MyHandler += value;
            }

            remove
            {
                Console.WriteLine("SessionUpdateEvent subscriber removed");
                MyHandler -= value;
            }
        }

        private List<ChatRoom> ChatRooms;

        public Server()
        {
            this.conn = InitializeDatabase("data", "database.sqlite");
            this.ChatRooms = new List<ChatRoom>();
        }

        ///////////////////////////////////////////////////////////////////////
        ///////////////////////// PUBLIC/API METHODS //////////////////////////
        ///////////////////////////////////////////////////////////////////////

        #region Login / Register

        /*
         * Returns 0 upon success
         * Error codes:
         * (-1) - database error
         * (1) - invalid nickname
         * (2) - invalid real name
         * (3) - invalid password
         * (4) - nickname already exists
         */
        public override int Register(string nickname, string realName, string password)
        {
            if (nickname.Length < 1)
            {
                return 1;
            }

            if (realName.Length < 1)
            {
                return 2;
            }

            if (password.Length < 1)
            {
                return 3;
            }

            if (DBController.UserExists(conn, nickname))
            {
                return 4;
            }

            if (!DBController.CreateUser(conn, nickname, realName, password))
            {
                return -1;
            }

            return 0;
        }

        /*
         * Returns false if password doesn't match or an error occurs
         */
        public override bool Login(string nickname, string password, string ip, int port)
        {
            if (!DBController.PasswordMatch(conn, nickname, password))
            {
                return false;
            }

            bool sessionCreated = DBController.CreateUpdateSession(conn, nickname, ip, port);
            if (sessionCreated)
            {
                //TODO: start heartbeat connection with client
                MyHandler?.Invoke(new LoggedClient(nickname, DBController.GetUserRealName(conn, nickname), ip, port));
            }
            return sessionCreated;
        }

        /*
         * Returns false if password doesn't match or an error occurs
         */
        public override bool Logout(string nickname, string password)
        {
            if (!DBController.PasswordMatch(conn, nickname, password))
            {
                return false;
            }

            bool sessionEnded = DBController.EndSession(conn, nickname);
            //TODO: terminate heartbeat connection with client
            return sessionEnded;
        }

        public override List<IClient> LoggedUsers(string nickname)
        {
            return DBController.LoggedUsers(conn, nickname);
        }

        public override string GetUserRealName(string nickname)
        {
            return DBController.GetUserRealName(conn, nickname);
        }

        #endregion

        #region ChatRoom
        public override string CreateChatRoom(IClient sender, List<IClient> users)
        {
            ChatRoom chatRoom = new ChatRoom(sender, users);
            chatRoom.InviteAllUsers();

            this.ChatRooms.Add(chatRoom);

            return chatRoom.Hash;
        }

        public override void SendMessageChatRoom(IClient sender, string hash, string message)
        {
            ChatRoom chatRoom = null;
            foreach(ChatRoom currentRoom in this.ChatRooms)
            {
                if (!currentRoom.Hash.Equals(hash))
                    continue;
                chatRoom = currentRoom;
                break;
            }

            if (chatRoom == null)
                return;

            chatRoom.SendMessage(sender, message);
        }
        #endregion

        #region Database

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
            DBController.TruncateSessions(conn);
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
            textStreamReader.Close();
        }

        private void TerminateDatabase(SQLiteConnection conn)
        {
            conn.Close();
            conn.Dispose();
        }

        #endregion
    }
}
