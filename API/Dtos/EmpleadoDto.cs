using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class EmpleadoDto
    {
        public int Id { get; set; }
        public string IdEmpleado { get; set; }

        public string Nombre { get; set; }

        public DateOnly DateReg { get; set; }

        public string NroContacto { get; set; }

        public int IdCargoFk { get; set; }

        public int IdMunicipioFk { get; set; }

        public int IdDireccionFk { get; set; }
    }
}