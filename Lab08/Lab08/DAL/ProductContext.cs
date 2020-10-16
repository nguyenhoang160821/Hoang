using Lab08.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Lab08.DAL
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("ProductContext")
        {

        }

        public DbSet<Product> Products { get; set; }    
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}