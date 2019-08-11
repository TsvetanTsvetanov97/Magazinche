using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using Magazinche.Data;
using Magazinche.Data.Models;
using Magazinche.Mapping;

namespace Magazinche.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        private readonly MagazincheDbContext db;

        public CategoryService(MagazincheDbContext db)
        {
            this.db = db;
        }
        
        public void Add<TViewModel>(TViewModel categoryModel)
        {
            db.Categories.Add( Mapper.Map(categoryModel, new Category()));
            db.SaveChanges();
        }
        public IEnumerable<TViewModel> All<TViewModel>()
        {
            var categories = db.Categories;
              return  categories.To<TViewModel>().ToList();
        }

      
    }
}
