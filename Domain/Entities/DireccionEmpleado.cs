using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DireccionEmpleado : BaseEntity
{

    public string TipoVia { get; set; }

    public int NumeroPrincipal { get; set; }

    public string LetraPrincipal { get; set; }

    public string Bis { get; set; }

    public string LetraSecundaria { get; set; }

    public string CardinalPrimario { get; set; }

    public int NumeroSecundario { get; set; }

    public string CardinalSecundario { get; set; }

    public string Complemento { get; set; }

    public int IdMunicipiofk { get; set; }

    public int IdEmpleadoFk { get; set; }

    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();
}
