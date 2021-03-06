﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Lab02.Models
{
    public class Category
    {
        [ScaffoldColumn(false)]
        public int CategoryID { get; set; }

        [Required, StringLength(100),Display (Name = "Name")]
        public string CategoryName { get; set; }

        [Display(Name = "Book Description")]
        public string Description { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}