using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibliothouris.Forms;

namespace Bibliothouris.Source.Book
{
    public class BookController
    {
        internal IBookView view { get; }
        private IBookAddView addView { get; }
        private IBookService service;

        public BookController(IBookService service, IBookView view, IBookAddView addView)
        {
            this.service = service;
            this.view = view;
            this.addView = addView;
            this.view.SetController(this);
            this.addView.SetController(this);
        }

        public void LoadAllBooks()
        {
            view.AddBooks(service.GetAllBooks());
            
        }
        public void AddBook(string title,string ISBN,string authorFirstName,string authorLastName)
        {
            service.AddBook(title,ISBN,authorFirstName,authorLastName);
            addView.Close();
            ClearAllBooks();
            LoadAllBooks();
        }

        public void ClearAllBooks()
        {
            view.ClearAllBooks();
        }
        public void addBookView()
        {
            addView.Clear();
            addView.ShowDialog();
        }
    }
}
