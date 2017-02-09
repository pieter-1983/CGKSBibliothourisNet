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
using Bibliothouris.Source.TheController;

namespace Bibliothouris.Forms
{
    public partial class StartScreen : Form
    {
        private MemberController memberController;
        private BookController bookController;
        private TheController theController;

        public StartScreen()
        {
        
            
            InitializeComponent();
        }
        public void SetControllers(MemberController memberController, BookController bookController)
        {
            this.memberController = memberController;
            this.bookController = bookController;
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
