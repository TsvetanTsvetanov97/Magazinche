using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Magazinche.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Magazinche.Data
{
    public class MagazincheDbContext : IdentityDbContext<User,IdentityRole<int>,int>
    {
        public MagazincheDbContext(DbContextOptions<MagazincheDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<BuyerPoduct> Purchases { get; set; } 
        public DbSet <Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Product>()
                .HasOne(p => p.Seller)
                .WithMany(s => s.Products)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<User>()
                .HasMany(s => s.Products)
                .WithOne(p => p.Seller);


            builder.Entity<BuyerPoduct>()
                .HasKey(p => new { p.BuyerId, p.ProductId });

            builder.Entity<BuyerPoduct>()
                .HasOne(p => p.Product)
                .WithMany(p => p.BuyerPoducts)
                .HasForeignKey(p => p.ProductId);

            builder.Entity<BuyerPoduct>()
                .HasOne(p => p.Buyer)
                .WithMany(b => b.BuyerProduct)
                .HasForeignKey(p => p.BuyerId);

            builder.Entity<Product>()
              .HasMany(p => p.Reviews)
              .WithOne(r => r.Product);

            builder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(p => p.Category);

            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
