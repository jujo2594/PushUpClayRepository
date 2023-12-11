using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class CargoConfiguration : IEntityTypeConfiguration<Cargo>
    {
        public void Configure(EntityTypeBuilder<Cargo> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("cargo");

            builder.Property(e => e.Id).HasColumnName("id");
            builder.Property(e => e.NombreCargo)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("nombreCargo");
        }
    }
}