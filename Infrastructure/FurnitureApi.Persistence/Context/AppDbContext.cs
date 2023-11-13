using System;
using System.Reflection;
using FurnitureApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FurnitureApi.Persistence.Context
{
    public class AppDbContext : DbContext
    {
        protected AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }


        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}

