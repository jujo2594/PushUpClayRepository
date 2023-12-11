using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class TurnoConfiguration : IEntityTypeConfiguration<Turno>
    {
        public void Configure(EntityTypeBuilder<Turno> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("turnos");

            builder.Property(e => e.Id).HasColumnName("id");
            builder.Property(e => e.HorTurnoF)
                .HasColumnType("time")
                .HasColumnName("horTurnoF");
            builder.Property(e => e.HorTurnoI)
                .HasColumnType("time")
                .HasColumnName("horTurnoI");
            builder.Property(e => e.NombreTurno)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("nombreTurno");  
        }
    }
}