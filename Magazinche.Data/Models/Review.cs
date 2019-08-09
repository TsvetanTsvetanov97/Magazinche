using System;
using System.Collections.Generic;
using System.Text;

namespace Magazinche.Data.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
