using Microsoft.EntityFrameworkCore;
using MiPrimerAPI.Models;
using System.Collections.Generic;

namespace MiPrimerAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Agregar datos de ejemplo (seed data)
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Laptop HP", Description = "Laptop para oficina", Price = 850.00m },
                new Product { Id = 2, Name = "Mouse Logitech", Description = "Mouse inalámbrico", Price = 25.99m },
                new Product { Id = 3, Name = "Monitor Samsung", Description = "Monitor 24 pulgadas", Price = 179.99m }
            );
        }
    }
}