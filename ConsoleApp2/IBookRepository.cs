using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public interface IBookRepository
    {
        List<Book> GetAll();
        bool Add(Book input);
    }
}
