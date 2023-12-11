using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("cliente");

            builder.HasIndex(e => e.IdDireccionFk, "IdDireccionFK");

            builder.HasIndex(e => e.IdMunicipioFk, "IdMunicipioFk");

            builder.HasIndex(e => e.IdCliente, "idCliente").IsUnique();

            builder.Property(e => e.Id).HasColumnName("id");
            builder.Property(e => e.DateReg).HasColumnName("dateReg");
            builder.Property(e => e.IdCliente)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("idCliente");
            builder.Property(e => e.IdDireccionFk).HasColumnName("IdDireccionFK");
            builder.Property(e => e.Nombre)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("nombre");
            builder.Property(e => e.NroContacto)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("nroContacto");

            builder.HasOne(d => d.IdDireccionFkNavigation).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.IdDireccionFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("cliente_ibfk_2");

            builder.HasOne(d => d.IdMunicipioFkNavigation).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.IdMunicipioFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("cliente_ibfk_1"); 
        }
    }
}