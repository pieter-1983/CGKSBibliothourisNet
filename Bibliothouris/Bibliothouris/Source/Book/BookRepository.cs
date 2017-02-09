using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bibliothouris.Source.Book
{
    public class BookRepository
    {
        private List<Book> books;

        public BookRepository()
        {
            books = new List<Book>();
        }

        public virtual void AddBook(Book book)
        {
            books.Add(book);
        }

        public virtual List<Book> GetAllBooks()
        {
            return books;
        }
            
        public virtual List<Book> getPartialISBN(string partialISBN) {
            partialISBN = partialISBN.Replace("\\*", ".*");
            Regex regx = new Regex(partialISBN);
            List<Book> listPartialISBN = new List<Book>();
            foreach (Book book in books) {
                if (regx.IsMatch(book.isbn)) {
                    listPartialISBN.Add(book);
                }
            }
            return listPartialISBN;
        }

        public virtual List<Book> getPartialTitle(string partialTitle) {
            partialTitle = partialTitle.Replace("\\*", ".*");
            Regex regx = new Regex(partialTitle);
            List<Book> listPartialTitle = new List<Book>();
            foreach(Book book in books) {
                if (regx.IsMatch(book.title)) {
                    listPartialTitle.Add(book);
                }
            }
            return listPartialTitle;
        }

        public virtual List<Book> getPartialFirstName(string partialFirstName) {
            partialFirstName = partialFirstName.Replace("\\*", ".*");
            Regex regx = new Regex(partialFirstName);
            List<Book> listPartialFirstName = new List<Book>();
            foreach(Book book in books) {
                if (regx.IsMatch(book.authorFirstName)) {
                    listPartialFirstName.Add(book);
                }
            }
            return listPartialFirstName;
        }

        public virtual List<Book> getPartialLastName(string partialLastName) {
            partialLastName = partialLastName.Replace("\\*", ".*");
            Regex regx = new Regex(partialLastName);
            List<Book> listPartialLastName = new List<Book>();
            foreach (Book book in books) {
                if (regx.IsMatch(book.authorFirstName)) {
                    listPartialLastName.Add(book);
                }
            }
            return listPartialLastName;
        }

    }
}
