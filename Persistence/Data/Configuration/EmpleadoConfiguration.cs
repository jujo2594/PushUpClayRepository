using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class EmpleadoConfiguration : IEntityTypeConfiguration<Empleado>
    {
        public void Configure(EntityTypeBuilder<Empleado> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("empleado");

            builder.HasIndex(e => e.IdCargoFk, "IdCargoFk");

            builder.HasIndex(e => e.IdDireccionFk, "IdDireccionFK");

            builder.HasIndex(e => e.IdMunicipioFk, "IdMunicipioFk");

            builder.HasIndex(e => e.IdEmpleado, "idEmpleado").IsUnique();

            builder.Property(e => e.Id).HasColumnName("id");
            builder.Property(e => e.DateReg).HasColumnName("dateReg");
            builder.Property(e => e.IdDireccionFk).HasColumnName("IdDireccionFK");
            builder.Property(e => e.IdEmpleado)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("idEmpleado");
            builder.Property(e => e.Nombre)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("nombre");
            builder.Property(e => e.NroContacto)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("nroContacto");

            builder.HasOne(d => d.IdCargoFkNavigation).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.IdCargoFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("empleado_ibfk_1");

            builder.HasOne(d => d.IdDireccionFkNavigation).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.IdDireccionFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("empleado_ibfk_3");

            builder.HasOne(d => d.IdMunicipioFkNavigation).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.IdMunicipioFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("empleado_ibfk_2");
        }
    }
}