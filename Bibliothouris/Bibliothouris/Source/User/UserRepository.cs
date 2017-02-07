using System;
using System.Collections.Generic;

namespace Bibliothouris.Source.User
{
    internal class UserRepository
    {

        private List<User> users;

        public UserRepository()
        {
            users = new List<User>();
        }

        internal List<User> GetAllUsers()
        {
            return users;
        }

        internal void AddUser(User user)
        {
            users.Add(user);
        }
    }
}