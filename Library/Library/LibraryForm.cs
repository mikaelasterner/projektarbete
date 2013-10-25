using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Library.Models;
using Library.Services;
using Library.Repositories;
using System.Data.Entity;

namespace Library
{
    public partial class LibraryForm : Form
    {
        public LibraryForm()
        {
            InitializeComponent();

            // Uncomment the line you wish to use
            // Use a derived strategy with a Seed-method
            Database.SetInitializer<LibraryContext>(new LibraryDbInit());

            // Recreate the database only if the models change
            //Database.SetInitializer<LibraryContext>(new DropCreateDatabaseIfModelChanges<LibraryContext>());

            // Always drop and recreate the database
            //Database.SetInitializer<LibraryContext>(new DropCreateDatabaseAlways<LibraryContext>());

            LibraryContext db = new LibraryContext();
            // Create the author-object
            Author alexDumas = new Author()
            {
                Name = "Alexandre Dumas"
            };
            // Create the book-object and assign the
            // Author-property with the author
            Book monteCristo = new Book()
            {
                Title = "The Count of Monte Cristo",
                Author = alexDumas
            };
            // Add the book to the DbSet of books.
            db.Books.Add(monteCristo);
            // Persist changes to



        }
    }
}
