using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class ContratoConfiguration : IEntityTypeConfiguration<Contrato>
    {
        public void Configure(EntityTypeBuilder<Contrato> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("contrato");

            builder.HasIndex(e => e.IdClienteFk, "IdClienteFk");

            builder.HasIndex(e => e.IdEmpleadoFk, "IdEmpleadoFk");

            builder.HasIndex(e => e.IdEstadoFk, "IdEstadoFk");

            builder.Property(e => e.Id).HasColumnName("id");
            builder.Property(e => e.FechContrato).HasColumnName("fechContrato");
            builder.Property(e => e.FechaFin).HasColumnName("fechaFin");

            builder.HasOne(d => d.IdClienteFkNavigation).WithMany(p => p.Contratos)
                .HasForeignKey(d => d.IdClienteFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("contrato_ibfk_3");

            builder.HasOne(d => d.IdEmpleadoFkNavigation).WithMany(p => p.Contratos)
                .HasForeignKey(d => d.IdEmpleadoFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("contrato_ibfk_2");

            builder.HasOne(d => d.IdEstadoFkNavigation).WithMany(p => p.Contratos)
                .HasForeignKey(d => d.IdEstadoFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("contrato_ibfk_1");
        }
    }
}