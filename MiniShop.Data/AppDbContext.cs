﻿using System;
using Microsoft.EntityFrameworkCore;
using MiniShop.Data.Config;
using MiniShop.Entity;

namespace MiniShop.Data
{
	public class AppDbContext : DbContext
	{
		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<CategoryProduct> CategoryProducts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //sql server baglantı cümlesi nuget managerdan sql kaldırıldı.

            //optionsBuilder.UseSqlServer(@"Server=localhost;Database=MiniShopDb;
            //User Id=SA;Password=reallyStrongPwd123;TrustServerCertificate=true");
            //base.OnConfiguring(optionsBuilder);


            optionsBuilder.UseSqlite("Data Source=MiniShop.sqlite");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new CategoryProductConfig()); 
           
            base.OnModelCreating(modelBuilder);
        }
    }
}

