using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibliothouris.Source.Book;

namespace Bibliothouris.Forms
{
    public interface IBookAddView
    {
        void SetController(BookController bookController);
        void Close();
        void Clear();
        DialogResult ShowDialog();
    }

    public partial class BookAddForm : Form, IBookAddView
    {
        private BookController bookController;
        public BookAddForm()
        {
            InitializeComponent();
        }


        public void SetController(BookController bookcontroller)
        {
            this.bookController = bookcontroller;
        }

        public void Clear()
        {
            ISBN.Text = "";
            Title.Text = "";
            AuthorFirstName.Text = "";
            AuthorLastName.Text = "";
        }

        private void BookAddForm_Load(object sender, EventArgs e) {

        }

        private void addBook_Click(object sender, EventArgs e) {
            bookController.AddBook(Title.Text, ISBN.Text, AuthorFirstName.Text, AuthorLastName.Text);
        }
    }
}
