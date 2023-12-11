using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Pais : BaseEntity
{

    public string Name { get; set; }

    public virtual ICollection<Departamento> Departamentos { get; set; } = new List<Departamento>();
}
