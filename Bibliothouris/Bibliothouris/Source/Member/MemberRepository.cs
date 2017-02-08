using System;
using System.Collections.Generic;

namespace Bibliothouris.Source.User
{
    public class MemberRepository
    {

        private List<User> users;

        public MemberRepository()
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