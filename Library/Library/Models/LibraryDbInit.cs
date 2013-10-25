using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace Library.Models
{
    /// <summary>
    /// Derived database strategy
    /// </summary>
    class LibraryDbInit : DropCreateDatabaseAlways<LibraryContext>
    {
        protected override void Seed(LibraryContext context)
        {
            base.Seed(context);

            // seeding data goes here..
            Author alexDumas = new Author()
            {
                Name = "Alexandre Dumas"
            };
            Book monteCristo = new Book()
            {
                Title = "The Count of Monte Cristo",
                Author = alexDumas
            };
            context.Books.Add(monteCristo);
            context.SaveChanges();
        }
    }
}
