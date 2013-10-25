using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repositories
{
    class BookRepository
    {
        LibraryContext _context;
        public BookRepository(LibraryContext context)
        {
            _context = context;
        }
        public IEnumerable<Book> All()
        {
            return _context.Books.ToList();
        }
    }
}
