using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Cliente : BaseEntity
{

    public string IdCliente { get; set; }

    public string Nombre { get; set; }

    public string NroContacto { get; set; }

    public DateOnly DateReg { get; set; }

    public int IdMunicipioFk { get; set; }

    public int IdDireccionFk { get; set; }

    public virtual ICollection<Contrato> Contratos { get; set; } = new List<Contrato>();

    public virtual DireccionCliente IdDireccionFkNavigation { get; set; }

    public virtual Municipio IdMunicipioFkNavigation { get; set; }
}
