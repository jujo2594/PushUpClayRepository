using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class ContratoDto
    {
        public int Id { get; set; }
        public DateOnly FechContrato { get; set; }

        public DateOnly FechaFin { get; set; }

        public int IdClienteFk { get; set; }

        public int IdEmpleadoFk { get; set; }

        public int IdEstadoFk { get; set; }
    }
}