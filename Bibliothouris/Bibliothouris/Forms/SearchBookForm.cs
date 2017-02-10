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



    public partial class SearchBookForm : Form, ISearchBook {

        private BookController bookcontroller;

        public SearchBookForm() {
            InitializeComponent();
        }

        public void SetController(BookController bookcontroller) {
            this.bookcontroller = bookcontroller;
        }

        public void Clear() {
            searchBookBox.Text = "";
            
        }

        private void SearchBooks_Load(object sender, EventArgs e) {

        }

        private void btnSearch_Click(object sender, EventArgs e) {
            if (comboBox1.SelectedIndex == 0) {
                bookcontroller.GetPartialISBN(searchBookBox.Text);
            }
            else if(comboBox1.SelectedIndex == 1) {
                bookcontroller.GetPartialTitle(searchBookBox.Text);
            }
            else if (comboBox1.SelectedIndex == 2) {
                bookcontroller.GetPartialFirstName(searchBookBox.Text);
            }
            else if(comboBox1.SelectedIndex == 3) {
                bookcontroller.GetPartialLastName(searchBookBox.Text);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
