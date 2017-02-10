﻿using System;
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
        internal ISearchBook bookSearch { get; }
        private ISearchBookResults bookResults { get; }
        private IBookAddView addView { get; }
        private IBookService service;

        public BookController(IBookView view, IBookAddView addView, IBookService service, ISearchBook bookSearch, ISearchBookResults bookResults)
        {
            this.service = service;
            this.view = view;
            this.addView = addView;
            this.view.SetController(this);
            this.addView.SetController(this);
            this.bookSearch = bookSearch;
            this.bookSearch.SetController(this);
            this.bookResults = bookResults;
            this.bookResults.SetController(this);
        }

        public void LoadAllBooks()
        {
            foreach(Book book in service.GetAllBooks()) {
                view.AddBook(book);
            }  
        }

        public void AddBook(string title, string ISBN, string authorFirstName, string authorLastName)
        {
            service.AddBook(title,ISBN,authorFirstName,authorLastName);
            addView.Close();
            ClearAllBooks();
            LoadAllBooks();
        } 

        public void GetPartialISBN(string partialISBN) {
            service.GetPartialISBN(partialISBN);
            bookSearch.Close();
        }
        public void GetPartialTitle(string partialTitle) {
            service.GetPartialTitle(partialTitle);
            bookSearch.Close();
        }
        public void GetPartialFirstName(string partialFirstName) {
            service.GetPartialFirstName(partialFirstName);
            bookSearch.Close();
        }
        public void GetPartialLastName(string partialLastName) {
            service.GetPartialLastName(partialLastName);
            bookSearch.Close();
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

        public void bookSearchView() {
            bookSearch.Clear();
            bookSearch.ShowDialog();
        }

        public void ClearAllBookResults() {
            bookResults.
        }
    }
}
