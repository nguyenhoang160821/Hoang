using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab08.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Qty { get; set; }
        public double Price { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
    }
}