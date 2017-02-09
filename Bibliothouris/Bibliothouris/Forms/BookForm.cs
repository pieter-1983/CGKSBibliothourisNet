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
    public interface IBookView
    {
        void SetController(BookController bookController);
        void AddBook(Book book);
        void ClearAllBooks();
        DialogResult ShowDialog();
    }


    public partial class BookForm : Form, IBookView
    {
        private BookController bookController;

        public BookForm()
        {
            InitializeComponent();
        }

        public void SetController(BookController bookController)
        {
            this.bookController = bookController;
        }

        public void AddBook(Book book) {
            bookView.Items.Add(CreateBookListViewItem(book));
        }

        public ListViewItem CreateBookListViewItem(Book book)
        {
                ListViewItem bookItem = new ListViewItem(book.isbn);
                bookItem.SubItems.Add(book.title);
                bookItem.SubItems.Add(book.authorFirstName);
                bookItem.SubItems.Add(book.authorLastName);

            return bookItem;
        }

        public void ClearAllBooks()
        {
            bookView.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e) {
            bookController.addBookView();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) {

        }

    }
}
