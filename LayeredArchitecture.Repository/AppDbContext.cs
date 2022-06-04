﻿using LayeredArchitecture.Core;
using LayeredArchitecture.Repository.Configurations;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace LayeredArchitecture.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //Tek Tek Eklemek istersek alt satırdaki gibi de  yapabiliriz.
            //modelBuilder.ApplyConfiguration(new ProductConfiguration());

            base.OnModelCreating(modelBuilder);
        }

    }
}
