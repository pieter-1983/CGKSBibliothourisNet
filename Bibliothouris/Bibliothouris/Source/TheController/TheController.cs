using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibliothouris.Forms;
using Bibliothouris.Source.Book;
using Bibliothouris.Source.User;

namespace Bibliothouris.Source.TheController
{
    class TheController
    {
        private MemberController memberController;
        private BookController bookController;
        private StartScreen startScreen;

        public TheController()
        {
            memberController = new MemberController(new MembersForm(), new MembersAddForm(), new MemberService());
            bookController = new BookController(new BookForm(), new BookAddForm(), new BookService());
            startScreen=new StartScreen();
            startScreen.SetControllers(memberController, bookController);
            startScreen.ShowDialog();
        }
    }
}
