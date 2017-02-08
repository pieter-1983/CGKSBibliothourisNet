using System;
using System.Collections.Generic;

namespace Bibliothouris.Source.User
{
    public class UserRepository
    {

        private List<User> users;

        public UserRepository()
        {
            users = new List<User>();
        }

        public virtual List<User> GetAllUsers()
        {
            return users;
        }

        public virtual void AddUser(User user)
        {
            users.Add(user);
        }
    }
}