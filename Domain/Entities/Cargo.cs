using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Cargo : BaseEntity
{
    public string NombreCargo { get; set; }

    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();
}
