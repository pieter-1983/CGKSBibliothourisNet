﻿using System;
using System.Collections.Generic;

namespace Bibliothouris.Source.User
{
    public interface IUserService
    {
        List<User> GetAllUsers();
        void AddUser(String userName);
    }

    public class UserService: IUserService
    {
        private static int counter;
        private UserRepository repository;

        public UserService() : this(new UserRepository())
        {
            
        }

        public UserService(UserRepository repository)
        {
            this.repository = repository;
        }

        public List<User> GetAllUsers()
        {
            return repository.GetAllUsers();
        }

        public void AddUser(string userName)
        {
            repository.AddUser(new User(++counter, userName));
        }
    }
}