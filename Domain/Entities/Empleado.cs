using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Empleado : BaseEntity
{
    public string IdEmpleado { get; set; }

    public string Nombre { get; set; }

    public DateOnly DateReg { get; set; }

    public string NroContacto { get; set; }

    public int IdCargoFk { get; set; }

    public int IdMunicipioFk { get; set; }

    public int IdDireccionFk { get; set; }

    public virtual ICollection<Contrato> Contratos { get; set; } = new List<Contrato>();

    public virtual Cargo IdCargoFkNavigation { get; set; }

    public virtual DireccionEmpleado IdDireccionFkNavigation { get; set; }

    public virtual Municipio IdMunicipioFkNavigation { get; set; }

    public virtual ICollection<Programacion> Programacions { get; set; } = new List<Programacion>();
}
