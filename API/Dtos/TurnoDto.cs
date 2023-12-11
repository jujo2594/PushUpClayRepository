using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class TurnoDto
    {
        public int Id { get; set; }
        public string NombreTurno { get; set; }

        public TimeOnly HorTurnoI { get; set; }

        public TimeOnly HorTurnoF { get; set; }
    }
}