using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliothouris.Source.Book
{
    public interface IBookService
    {
        List<Book> GetAllBooks();
        void AddBook(string title, string isbn, string authorFirstName, string authorSecondName);
        List<Book> GetPartialISBN(string partialISBN);
        List<Book> GetPartialTitle(string partialTitle);
        List<Book> GetPartialFirstName(string partialFirstName);
        List<Book> GetPartialLastName(string partialLastName);
    }


    public class BookService : IBookService
    {
        private BookRepository bookRepository;

        public BookService() : this(new BookRepository())
        {

        }

        public BookService(BookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public List<Book> GetAllBooks()
        {
            return bookRepository.GetAllBooks();
        }
    
        public void AddBook(string title, string isbn, string authorFirstName, string authorSecondName)
        {
            bookRepository.AddBook(new Book(title, isbn, authorFirstName, authorSecondName));
        }

        public List<Book> GetPartialISBN(string partialISBN) {
            return bookRepository.getPartialISBN(partialISBN);
        }

        public List<Book> GetPartialTitle(string partialTitle) {
            return bookRepository.getPartialTitle(partialTitle);
        }

        public List<Book> GetPartialFirstName(string partialFirstName) {
            return bookRepository.getPartialFirstName(partialFirstName);
        }

        public List<Book> GetPartialLastName(string partialLastName) {
           return bookRepository.getPartialLastName(partialLastName);
        }

    }
}



