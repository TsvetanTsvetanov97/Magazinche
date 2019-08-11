using System;
using System.Collections.Generic;
using System.Text;
using Magazinche.Mapping;
using Magazinche.Data.Models;

namespace Magazinche.Web.Models.CategoryViewModels
{
    public class CategoryAddModel : IMapTo<Category>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
