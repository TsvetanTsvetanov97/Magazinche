using Magazinche.Data.Models;
using Magazinche.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Magazinche.Web.Models.CategoryViewModels
{
    public class CategoryViewModel : IMapFrom<Category>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
