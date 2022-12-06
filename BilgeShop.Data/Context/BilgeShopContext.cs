using BilgeShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeShop.Data.Context
{
    public class BilgeShopContext:DbContext
    {
        public BilgeShopContext(DbContextOptions<BilgeShopContext>options) : base(options)
        {

        }
        public DbSet<UserEntity> User => Set<UserEntity>();
        public DbSet<ProductEntity> Products => Set<ProductEntity>();
        public DbSet<CategoryEntity> Categories=> Set<CategoryEntity>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ProductEntityConfiguration());
            modelBuilder.ApplyConfiguration(new UserEntityConfiguration());


            base.OnModelCreating(modelBuilder);
        }

    }
}
