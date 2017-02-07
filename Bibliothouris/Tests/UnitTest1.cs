using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using Bibliothouris.Source.User;
using System.Collections.Generic;
using Bibliothouris.Forms;

namespace Tests
{
    [TestClass]
    public class TestUserController
    {
        private IUserService userService = Substitute.For<IUserService>();
        private IUserView userView = Substitute.For<IUserView>();
        private IUserAddView userAddView = Substitute.For<IUserAddView>();

        [TestInitialize]

        [TestMethod]
        public void LoadAllUsers_ShouldGetAllUsers()
        {
            var userSeppe = new User(1, "Seppe");
            var userJohan = new User(2, "Johan");
            var userList = new List<User>
            {
                userSeppe,
                userJohan
            };

            userService.GetAllUsers().Returns(userList);
            
            new UserController(userView, userAddView, userService).LoadAllUsers();

            userView.Received().AddUser(userSeppe);
            userView.Received().AddUser(userJohan);
        }

        [TestMethod]
        public void AddUser_ShouldAddAUserToTheService()
        {
            var userSeppe = new User(1, "Seppe");
            var userJohan = new User(2, "Johan");
            var userList = new List<User>
            {
                userSeppe,
                userJohan
            };

            userService.GetAllUsers().Returns(userList);

            new UserController(userView, userAddView, userService).AddUser("Seppe");

            userAddView.Received().Close();
            userService.Received().AddUser("Seppe");
            userView.Received().ClearAllUsers();
            userView.Received().AddUser(userSeppe);
            userView.Received().AddUser(userJohan);
        }

        [TestMethod]
        public void OpenAddView_ShouldOpenAddView()
        {
            new UserController(userView, userAddView, userService).addUserView();

            userAddView.Received().Clear();
            userAddView.Received().ShowDialog();
        }
    }
}
