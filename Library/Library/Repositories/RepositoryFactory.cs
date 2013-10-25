using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Models;

namespace Library.Repositories
{
    class RepositoryFactory
    {
        /// <summary>
        /// Wrapper property to access the context
        /// </summary>
        static LibraryContext context
        {
            get { return ContextSingelton.GetContext(); }
        }

        // add factory methods for your repositories here..
        public static BookRepository GetBookRepository()
        {
            return new BookRepository(RepositoryFactory.context);
        }
        
    }
}
