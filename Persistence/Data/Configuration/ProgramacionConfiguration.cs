using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class ProgramacionConfiguration : IEntityTypeConfiguration<Programacion>
    {
        public void Configure(EntityTypeBuilder<Programacion> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("programacion");

            builder.HasIndex(e => e.IdContratoFk, "IdContratoFk");

            builder.HasIndex(e => e.IdEmpleadoFk, "IdEmpleadoFk");

            builder.HasIndex(e => e.IdTurnoFk, "IdTurnoFk");

            builder.Property(e => e.Id).HasColumnName("id");

            builder.HasOne(d => d.IdContratoFkNavigation).WithMany(p => p.Programacions)
                .HasForeignKey(d => d.IdContratoFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("programacion_ibfk_2");

            builder.HasOne(d => d.IdEmpleadoFkNavigation).WithMany(p => p.Programacions)
                .HasForeignKey(d => d.IdEmpleadoFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("programacion_ibfk_1");

            builder.HasOne(d => d.IdTurnoFkNavigation).WithMany(p => p.Programacions)
                .HasForeignKey(d => d.IdTurnoFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("programacion_ibfk_3");
        }
    }
}