using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliothouris.Source.Book
{
    public class Book
    {
        public int ID { get; }
        public string title { get; }
        public string isbn { get; }
        public string authorFirstName { get; }
        public string authorLastName { get; }

        public Book(int ID, string title, string isbn, string authorFirstName, string authorLastName)
        {
            this.ID = ID;
            this.title = title;
            this.isbn = isbn;
            this.authorFirstName = authorFirstName;
            this.authorLastName = authorLastName;
        }
    }
}
