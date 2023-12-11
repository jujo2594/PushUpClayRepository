using System;
using System.Collections.Generic;
using System.Reflection;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Persistence.Data;

public partial class contextSeguridad : DbContext
{
    public contextSeguridad()
    {
    }
    public contextSeguridad(DbContextOptions<contextSeguridad> options)
        : base(options)
    {
    }
    public virtual DbSet<Cargo> Cargos { get; set; }
    public virtual DbSet<Cliente> Clientes { get; set; }
    public virtual DbSet<Contrato> Contratos { get; set; }
    public virtual DbSet<Departamento> Departamentos { get; set; }
    public virtual DbSet<DireccionCliente> Direccionclientes { get; set; }
    public virtual DbSet<DireccionEmpleado> Direccionempleados { get; set; }
    public virtual DbSet<Empleado> Empleados { get; set; }
    public virtual DbSet<Estado> Estados { get; set; }
    public virtual DbSet<Municipio> Municipios { get; set; }
    public virtual DbSet<Pais> Pais { get; set; }
    public virtual DbSet<Programacion> Programacions { get; set; }
    public virtual DbSet<Turno> Turnos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) // 2611
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
