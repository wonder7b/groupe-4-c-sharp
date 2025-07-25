using fa.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace fa.Services
{
    // Represents the database session
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Specifies the database file to be used
            optionsBuilder.UseSqlite("Data Source=facturation.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Ajoute des données initiales (seeding) lors de la création de la base de données.
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Code = "001", Name = "Ordinateur Portable", Price = 1200, TaxCategory = TaxCategory.A },
                new Product { Id = 2, Code = "002", Name = "Souris Gamer", Price = 45, TaxCategory = TaxCategory.A },
                new Product { Id = 3, Code = "003", Name = "Livre C# pour les Pros", Price = 35, TaxCategory = TaxCategory.C },
                new Product { Id = 4, Code = "004", Name = "Clavier Mécanique", Price = 150, TaxCategory = TaxCategory.B }
            );
        }
    }

    // Service to manage database operations
    public class DatabaseService
    {
        public static void InitializeDatabase()
        {
            using (var context = new AppDbContext())
            {
                // This will create the database and apply the schema if it doesn't exist
                context.Database.EnsureCreated();
            }
        }
    }
}
