using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibliothouris.Source.User;
using Bibliothouris.Forms;

namespace Bibliothouris
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           /* UserController userController = new UserController(new UsersForm(), new UserAddForm(), new UserService());
            userController.view.ShowDialog();*/
            MemberController memberController = new MemberController(new MembersForm(), new MembersAddForm(), new MemberService());
            memberController.view.ShowDialog();
                ;
        }
    }
}
