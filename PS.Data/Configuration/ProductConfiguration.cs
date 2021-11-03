using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Data.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            //Modifier le nom de la table product_provider générer pour l'association many to many
            builder.HasMany(p => p.Providers)
                .WithMany(p => p.Products)
                .UsingEntity(p => p.ToTable("Providing"));

            //Ajouter FK de category dans product
            builder.HasOne(p => p.MyCategory)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
