using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class DireccionEmpleadoConfiguration : IEntityTypeConfiguration<DireccionEmpleado>
    {
        public void Configure(EntityTypeBuilder<DireccionEmpleado> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("direccionempleado");

            builder.Property(e => e.Id).HasColumnName("id");
            builder.Property(e => e.Bis)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("bis");
            builder.Property(e => e.CardinalPrimario)
                .IsRequired()
                .HasMaxLength(1)
                .HasColumnName("cardinalPrimario");
            builder.Property(e => e.CardinalSecundario)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("cardinalSecundario");
            builder.Property(e => e.Complemento)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("complemento");
            builder.Property(e => e.LetraPrincipal)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("letraPrincipal");
            builder.Property(e => e.LetraSecundaria)
                .IsRequired()
                .HasMaxLength(2)
                .HasColumnName("letraSecundaria");
            builder.Property(e => e.NumeroPrincipal).HasColumnName("numeroPrincipal");
            builder.Property(e => e.NumeroSecundario).HasColumnName("numeroSecundario");
            builder.Property(e => e.TipoVia)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("tipoVia");
        }
    }
}