﻿using System;
using Microsoft.EntityFrameworkCore;
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
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=MiniShopDb;
            User Id=SA;Password=reallyStrongPwd123;TrustServerCertificate=true");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
