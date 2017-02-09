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

    }
}



