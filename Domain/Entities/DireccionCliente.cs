using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DireccionCliente : BaseEntity
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

    public int IdClienteFk { get; set; }

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();
}
