using System.Collections.Generic;

namespace Fritz
{
    public static class UserManager
    {
        private static readonly Dictionary<string, string> Users = new Dictionary<string, string>();

        public static bool IsValidUser(string username, string password)
        {
            return Users.ContainsKey(username) && Users[username] == password;
        }

        public static bool RegisterUser(string username, string password)
        {
            if (Users.ContainsKey(username))
            {
                return false; // Username already exists
            }

            Users[username] = password;
            return true;
        }
    }
}