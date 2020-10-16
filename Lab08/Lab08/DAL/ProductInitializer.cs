using Lab08.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Lab08.DAL
{
    public class ProductInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            var products = new List<Product>
            {
                new Product{ProductName="Television",Qty=5,Price=10},
                new Product{ProductName="Phone",Qty=15,Price=45},
                new Product{ProductName="Card",Qty=12,Price=3.5},
                new Product{ProductName="Book",Qty=7,Price=13},              
            };
            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();
            var categories = new List<Category>
            {
                new Category{CategoryID=1,Title="Watching",ProductID=1},
                new Category{CategoryID=2,Title="Saw",ProductID=2,},
                new Category{CategoryID=3,Title="Make",ProductID=3,},
                new Category{CategoryID=4,Title="Care",ProductID=4,},

            };
            categories.ForEach(s => context.Categories.Add(s));
            context.SaveChanges();
        }
    }
}