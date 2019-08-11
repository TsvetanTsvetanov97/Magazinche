using AutoMapper;
using Magazinche.Data;
using Magazinche.Data.Models;
using Magazinche.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magazinche.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private MagazincheDbContext db;

        public ProductService(MagazincheDbContext db)
        {
            this.db = db;
        }

        public void Add<TViewModel>(TViewModel productModel)
        {
            this.db.Add(Mapper.Map(productModel, new Product()));
            db.SaveChanges();
        }

        public IEnumerable<TViewModel> All<TViewModel>()
        {
              return this.db.Products.To<>
        }
    }
}
