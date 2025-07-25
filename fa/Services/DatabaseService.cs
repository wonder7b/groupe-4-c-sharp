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
                new Product { Id = 1, Code = "001", Nom = "Ordinateur Portable", Prix = 1200, Categorie = TaxCategory.A },
                new Product { Id = 2, Code = "002", Nom = "Souris", Prix = 45, Categorie = TaxCategory.A },
                new Product { Id = 3, Code = "003", Nom = "Livre C#", Prix = 35, Categorie = TaxCategory.C },
                new Product { Id = 4, Code = "004", Nom = "Clavier", Prix = 150, Categorie = TaxCategory.B }
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
