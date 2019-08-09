using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Magazinche.Data.Models
{
    public class BuyerPoduct
    {

      
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int BuyerId { get; set;}
        public User Buyer { get; set; }
    }
}
