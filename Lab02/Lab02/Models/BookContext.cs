using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace Lab02.Models
{
    public class BookContext : DbContext
    {
        public BookContext() : base("BooksLibrary")
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}