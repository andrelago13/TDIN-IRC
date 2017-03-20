using IRC_Common;
using IRC_Common.Models;
using System;
using System.Collections.Generic;
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

            SQLiteParameter nickParam = new SQLiteParameter("@nick", DbType.String);
            nickParam.Value = nickname;
            SQLiteParameter nameParam = new SQLiteParameter("@name", DbType.String);
            nameParam.Value = realname;
            SQLiteParameter pwParam = new SQLiteParameter("@pw", DbType.String);
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

            SQLiteParameter nickParam = new SQLiteParameter("@nick", DbType.String);
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

            SQLiteParameter nickParam = new SQLiteParameter("@nick", DbType.String);
            nickParam.Value = nickname;
            SQLiteParameter pwParam = new SQLiteParameter("@pw", DbType.String);
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

            SQLiteParameter nickParam = new SQLiteParameter("@nick", DbType.String);
            nickParam.Value = nickname;
            SQLiteParameter ipParam = new SQLiteParameter("@ip", DbType.String);
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

            SQLiteParameter nickParam = new SQLiteParameter("@nick", DbType.String);
            nickParam.Value = nickname;

            command.Parameters.Add(nickParam);

            command.Prepare();
            conn.Open();
            int result = command.ExecuteNonQuery();
            conn.Close();

            return result > 0;
        }

        public static List<IClient> LoggedUsers(SQLiteConnection conn, string askingNickname)
        {
            List<IClient> result = new List<IClient>();

            SQLiteCommand command = new SQLiteCommand(null, conn);
            command.CommandText = "SELECT sessions.nickname, users.realname, sessions.ip, sessions.port " +
                "FROM sessions INNER JOIN users ON sessions.nickname = users.nickname WHERE NOT sessions.nickname = @nick";

            SQLiteParameter nickParam = new SQLiteParameter("@nick", DbType.String);
            nickParam.Value = askingNickname;

            command.Parameters.Add(nickParam);

            command.Prepare();
            conn.Open();
            using (SQLiteDataReader r = command.ExecuteReader())
            {
                while (r.Read())
                {
                    result.Add(new LoggedClient(r.GetString(0), r.GetString(1), r.GetString(2), r.GetInt32(3)));
                }

                r.Close();
            }
            conn.Close();

            return result;
        }

        public static string GetUserRealName(SQLiteConnection conn, string nickname)
        {
            SQLiteCommand command = new SQLiteCommand(null, conn);
            command.CommandText = "SELECT realname FROM users WHERE nickname = @nick";

            SQLiteParameter nickParam = new SQLiteParameter("@nick", DbType.String);
            nickParam.Value = nickname;

            command.Parameters.Add(nickParam);

            string result = null;
            command.Prepare();
            conn.Open();
            using (SQLiteDataReader r = command.ExecuteReader())
            {
                if (r.Read())
                {
                    result = r.GetString(0);
                }
                r.Close();
            }
            conn.Close();

            return result;
        }

        public static void TruncateSessions(SQLiteConnection conn)
        {
            SQLiteCommand command1 = new SQLiteCommand(null, conn);
            command1.CommandText = "DELETE FROM sessions";
            SQLiteCommand command2 = new SQLiteCommand(null, conn);
            command2.CommandText = "VACUUM";

            command1.Prepare();
            command2.Prepare();
            conn.Open();
            command1.ExecuteNonQuery();
            command2.ExecuteNonQuery();
            conn.Close();
        }
    }
}
