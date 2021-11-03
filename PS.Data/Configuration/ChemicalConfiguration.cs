using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Data.Configuration
{
    public class ChemicalConfiguration : IEntityTypeConfiguration<Chemical>
    {
        public void Configure(EntityTypeBuilder<Chemical> builder)
        {
     
            builder.OwnsOne(p => p.Myadresse, add => {
                 add.Property(b => b.City).HasColumnName("MyCity").IsRequired();
                 add.Property(b => b.StreetAddress).HasColumnName("MyAddress").HasMaxLength(50);
            }); 



        }
    }
}
