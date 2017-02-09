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
        void AddBooks(List<Book> books);
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void SetController(BookController bookController)
        {
            this.bookController = bookController;
        }

        public void AddBooks(List<Book> books)
        {
            foreach (var book in books)
            {
                ListViewItem bookItem = new ListViewItem(book.ID.ToString());
                bookItem.SubItems.Add(book.isbn);
                bookItem.SubItems.Add(book.title);
                bookItem.SubItems.Add(book.authorFirstName);
                bookItem.SubItems.Add(book.authorLastName);
                bookView.Items.Add(bookItem);
            }
        }

        public void ClearAllBooks()
        {
           
        }

    }
}
