
using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class BookRepository : IBookRepository
    {
        private List<Book> Books { get; set; }
        internal BookRepository()
        {
            Books = new List<Book>();
        }
        public bool Add(Book input)
        {
            Books.Add(input);
            return true;
        }
        public List<Book> GetAll() => Books;

    }
}
