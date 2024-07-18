using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public class BookRepository2
    {
        public List<Book> Books;
        public static BookRepository2 _repo;
        private BookRepository2()
        {
            Books = new List<Book>();
        }

        public static BookRepository2 GetClass()
        {
            if (_repo == null) _repo = new BookRepository2();
            return _repo;
        }
        public List<Book> GetBooks()
        { 
            return Books;
        }
    }
}
