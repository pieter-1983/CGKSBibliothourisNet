using Bibliothouris.Source.Book;
using Bibliothouris.Source.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliothouris.Forms
{
    public partial class StartScreen : Form
    {
        private MemberController memberController;
        private BookController bookController;

        public StartScreen()
        {
            memberController = new MemberController(new MembersForm(), new MembersAddForm(), new MemberService());
            bookController = new BookController(new BookForm(), new BookAddForm(), new BookService());
            InitializeComponent();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            memberController.view.ShowDialog();
        }


        private void btnBooks_Click_1(object sender, EventArgs e)
        {
            bookController.view.ShowDialog();
        }
    }
}
