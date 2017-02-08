using Bibliothouris.Source.User;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass]
    public class UserServiceTest
    {
        private UserRepository repository = Substitute.For<UserRepository>();
        private UserService userService;

        [TestInitialize]
        public void Setup()
        {
             userService = new UserService(repository);
        }

        [TestMethod]
        public void GetAllUsers_ShouldGetAllUsers()
        {
            List<User> users = new List<User>
            {
                new User(1, "Seppe"),
                new User(2, "Johan")
            };

            repository.GetAllUsers().Returns(users);

            Assert.AreEqual(users, userService.GetAllUsers());
        }
        
        [TestMethod]
        public void AddUser_ShouldAddUser()
        {
            userService.AddUser("Seppe");

            repository.Received().AddUser(Arg.Is<User>(x => x.Name.Equals("Seppe") && x.ID == 1));
        }
    }
}
