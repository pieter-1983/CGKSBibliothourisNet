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

namespace Bibliothouris.Forms {
    public partial class StartScreen : Form {

        public StartScreen() {
            InitializeComponent();
        }

        private void btnMembers_Click(object sender, EventArgs e) {

            MemberController memberController = new MemberController(new MembersForm(), new MembersAddForm(), new MemberService());

            memberController.view.ShowDialog();

        }
    

        private void btnBooks_Click(object sender, EventArgs e) {

            BookController bookController = new BookController(new BookService(), new BookForm(), new BookAddForm());
    
            bookController.view.ShowDialog();

        }
    }
}
