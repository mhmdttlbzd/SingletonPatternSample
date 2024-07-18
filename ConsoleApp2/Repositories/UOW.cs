using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Repositories
{
    public class UOW
    {
        private static BookRepository bookRepository;
        public IBookRepository GetBookRepository()
        {
            if (bookRepository == null)
            {
                bookRepository = new BookRepository();
            }
            return bookRepository;
        }
    }
}
