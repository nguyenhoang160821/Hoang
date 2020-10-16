using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema; 

namespace Lab08.Models
{
    public class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CategoryID { get; set; }
        public string Title { get; set; }
        public int ProductID { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}