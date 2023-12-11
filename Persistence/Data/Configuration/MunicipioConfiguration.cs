using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class MunicipioConfiguration : IEntityTypeConfiguration<Municipio>
    {
        public void Configure(EntityTypeBuilder<Municipio> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("municipio");

            builder.HasIndex(e => e.IdDepartamentoFk, "idDepartamentoFk");

            builder.Property(e => e.Id).HasColumnName("id");
            builder.Property(e => e.IdDepartamentoFk).HasColumnName("idDepartamentoFk");
            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("name");

            builder.HasOne(d => d.IdDepartamentoFkNavigation).WithMany(p => p.Municipios)
                .HasForeignKey(d => d.IdDepartamentoFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("municipio_ibfk_1");
        }
    }
}