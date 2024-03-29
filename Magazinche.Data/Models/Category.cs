﻿using Magazinche.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magazinche.Data.Models
{
   public class Category
    {
        public int Id { get; set; }

   

        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
