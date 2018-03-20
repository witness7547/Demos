//https://www.thinkprogramming.co.uk/code-first-with-mysql-and-entity-framework-6/

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (LibraryContext db = new LibraryContext())
            {
                Author myAuthor = new Author();
                myAuthor.Forenames = "Christian";
                myAuthor.Surname = "Nagel";

                Book myBook = new Book();
                myBook.Author = myAuthor;
                myBook.Title = "C# Pro";


                db.Books.Add(myBook);
                db.Authors.Add(myAuthor);

                db.SaveChanges();
            }
        }

        public class LibraryContext : DbContext
        {
            public LibraryContext() : base("name=LibraryContext") { }

            public DbSet<Book> Books { get; set; }
            public DbSet<Author> Authors { get; set; }
        }

        public class Book
        {
            [Key]
            public int Id { get; set; }
            public string Title { get; set; }
            public virtual Author Author { get; set; }
        }

        public class Author
        {
            [Key]
            public int Id { get; set; }
            public string Forenames { get; set; }
            public string Surname { get; set; }
            public string Age { get; set; }
        }
    }
}
