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

    public interface ISearchBook {

        void SetController(BookController bookcontroller);
        void Close();
        void Clear();
        DialogResult ShowDialog();
    }



    public partial class SearchBooks : Form, ISearchBook {

        private BookController bookcontroller;

        public SearchBooks() {
            InitializeComponent();
        }

        public void SetController(BookController bookcontroller) {
            this.bookcontroller = bookcontroller;
        }

        public void Clear() {
            ISBN.Text = "";
            Title.Text = "";
            AuthorFirstName.Text = "";
            AuthorLastName.Text = "";
        }

        private void SearchBooks_Load(object sender, EventArgs e) {

        }

        private void btnSearch_Click(object sender, EventArgs e) {

        }
    }
}
