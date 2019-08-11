using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Magazinche.Data.Models
{
    public class Product
    {
        public int Id { get; set; }

        public int Count { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public bool IsAvailable { get; set; }

        public int SellerId { get; set; }
        public User Seller { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }


        public ICollection<BuyerPoduct> BuyerPoducts { get; set; } = new List<BuyerPoduct>();

        public ICollection<Review> Reviews { get; set; } = new List<Review>();

       
    }
}
