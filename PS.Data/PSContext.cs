using Microsoft.EntityFrameworkCore;
using PS.Data.Configuration;
using PS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PS.Data
{
    public class PSContext : DbContext
    {
        public PSContext()
        {
            Database.EnsureCreated();  
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=DendenMohamedBedisDB;Integrated Security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new CategoryConfiguration().Configure(modelBuilder.Entity<Category>());
            new ChemicalConfiguration().Configure(modelBuilder.Entity<Chemical>());
            new ProductConfiguration().Configure(modelBuilder.Entity<Product>());

            foreach (var property in modelBuilder.Model.GetEntityTypes()
                        .SelectMany(t => t.GetProperties())
                        .Where(p => p.ClrType == typeof(string) && p.Name.StartsWith("Name")))
            {
                property.SetColumnName("MyName");
            }
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Chemical> Chemicals { get; set; }
        public DbSet<Biological> Biologicals { get; set; }
    }
}
