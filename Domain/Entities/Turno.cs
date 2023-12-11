using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Turno : BaseEntity
{

    public string NombreTurno { get; set; }

    public TimeOnly HorTurnoI { get; set; }

    public TimeOnly HorTurnoF { get; set; }

    public virtual ICollection<Programacion> Programacions { get; set; } = new List<Programacion>();
}
