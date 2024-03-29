﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Magazinche.Data.Models
{
    // Add profile data for application users by adding properties to the User class
    public class User : IdentityUser<int>
    {
    
        public ICollection<Product> Products { get; set; } = new List<Product>();

    
        public ICollection<BuyerPoduct> BuyerProduct { get; set; } = new List<BuyerPoduct>();
    }
}
