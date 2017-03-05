using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace IRC_Server
{
    class DBController
    {
        public static bool CreateUser(SQLiteConnection conn, string nickname, string realname, string password)
        {
            SQLiteCommand command = new SQLiteCommand(null, conn);
            command.CommandText = "INSERT INTO users (nickname, realname, password) VALUES (@nick, @name, @pw)";

            SQLiteParameter nickParam = new SQLiteParameter("@nick", DbType.String, nickname.Length);
            nickParam.Value = nickname;
            SQLiteParameter nameParam = new SQLiteParameter("@name", DbType.String, realname.Length);
            nameParam.Value = realname;
            SQLiteParameter pwParam = new SQLiteParameter("@pw", DbType.String, password.Length);
            pwParam.Value = password;

            command.Parameters.Add(nickParam);
            command.Parameters.Add(nameParam);
            command.Parameters.Add(pwParam);
            
            command.Prepare();
            conn.Open();
            int result = command.ExecuteNonQuery();
            conn.Close();

            return result > 0;
        }

        public static bool UserExists(SQLiteConnection conn, string nickname)
        {
            SQLiteCommand command = new SQLiteCommand(null, conn);
            command.CommandText = "SELECT COUNT(nickname) FROM users WHERE nickname = @nick";

            SQLiteParameter nickParam = new SQLiteParameter("@nick", DbType.String, nickname.Length);
            nickParam.Value = nickname;

            command.Parameters.Add(nickParam);
            
            command.Prepare();
            conn.Open();
            int rows = Convert.ToInt32(command.ExecuteScalar());
            conn.Close();

            return rows > 0;
        }

        public static bool PasswordMatch(SQLiteConnection conn, string nickname, string password)
        {
            SQLiteCommand command = new SQLiteCommand(null, conn);
            command.CommandText = "SELECT COUNT(nickname) FROM users WHERE nickname = @nick AND password = @pw";

            SQLiteParameter nickParam = new SQLiteParameter("@nick", DbType.String, nickname.Length);
            nickParam.Value = nickname;
            SQLiteParameter pwParam = new SQLiteParameter("@pw", DbType.String, nickname.Length);
            pwParam.Value = password;

            command.Parameters.Add(nickParam);
            command.Parameters.Add(pwParam);

            command.Prepare();
            conn.Open();
            int rows = Convert.ToInt32(command.ExecuteScalar());
            conn.Close();

            return rows > 0;
        }

        public static bool CreateUpdateSession(SQLiteConnection conn, string nickname, string ip, int port)
        {
            SQLiteCommand command = new SQLiteCommand(null, conn);
            command.CommandText = "INSERT OR REPLACE INTO sessions (nickname, ip, port) VALUES (@nick, @ip, @port)";

            SQLiteParameter nickParam = new SQLiteParameter("@nick", DbType.String, nickname.Length);
            nickParam.Value = nickname;
            SQLiteParameter ipParam = new SQLiteParameter("@ip", DbType.String, ip.Length);
            ipParam.Value = ip;
            SQLiteParameter portParam = new SQLiteParameter("@port", DbType.Int32);
            portParam.Value = port;

            command.Parameters.Add(nickParam);
            command.Parameters.Add(ipParam);
            command.Parameters.Add(portParam);

            command.Prepare();
            conn.Open();
            int result = command.ExecuteNonQuery();
            conn.Close();

            return result > 0;
        }

        public static bool EndSession(SQLiteConnection conn, string nickname)
        {
            SQLiteCommand command = new SQLiteCommand(null, conn);
            command.CommandText = "DELETE FROM sessions WHERE nickname = @nick";

            SQLiteParameter nickParam = new SQLiteParameter("@nick", DbType.String, nickname.Length);
            nickParam.Value = nickname;

            command.Parameters.Add(nickParam);

            command.Prepare();
            conn.Open();
            int result = command.ExecuteNonQuery();
            conn.Close();

            return result > 0;
        }
    }
}
