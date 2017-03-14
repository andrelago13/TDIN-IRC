using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRC_Common
{
    public class Utils
    {
        public static readonly Dictionary<int, string> ErrorCodes = new Dictionary<int, string>()
        {
            { -1, "Database Error" },
            { 0, "Success" },
            { 1, "Invalid nickname" },
            { 2, "Invalid real name" },
            { 3, "Invalid password" },
            { 4, "Username already exists" }
        };
    }
}
