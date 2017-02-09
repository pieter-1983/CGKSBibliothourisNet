using Bibliothouris.Source.Book;
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

    public interface ISearchBookResults {

        void SetController(BookController bookcontroller);
        void GetPartialISBN(Book book);
        void GetPartialTitle(Book book);
        void GetPartialFirstName(Book book);
        void GetPartialLastName(Book book);
        DialogResult ShowDialog();
    }

    public partial class SearchBookResults : Form, ISearchBookResults {

        private BookController bookcontroller;

        public SearchBookResults() {
            InitializeComponent();
        }

        public void SetController(BookController bookcontroller) {
            this.bookcontroller = bookcontroller;
        }

        public ListViewItem CreateBookSearchResultListViewItem(Book book) {
            ListViewItem bookItem = new ListViewItem(book.isbn);
            bookItem.SubItems.Add(book.title);
            bookItem.SubItems.Add(book.authorFirstName);
            bookItem.SubItems.Add(book.authorLastName);

            return bookItem;
        }

        public void GetPartialISBN(Book book) {
            SearchBookView.Items.Add(CreateBookSearchResultListViewItem(book));
            
        }

        public void GetPartialTitle(Book book) {
            SearchBookView.Items.Add(CreateBookSearchResultListViewItem(book));
        }

        public void GetPartialFirstName(Book book) {
            SearchBookView.Items.Add(CreateBookSearchResultListViewItem(book));
        }

        public void GetPartialLastName(Book book) {
            SearchBookView.Items.Add(CreateBookSearchResultListViewItem(book));
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
