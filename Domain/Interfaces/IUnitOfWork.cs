using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUnitOfWork
    {
        public ICargo Cargos { get; } // 2611
        public ICliente Clientes { get; } // 2611
        public IContrato Contratos { get; } // 2611
        public IDepartamento Departamentos { get; } // 2611
        public IDireccionCliente DireccionClientes { get; } // 2611
        public IDireccionEmpleado DireccionEmpleados { get; } // 2611
        public IEmpleado Empleados { get; } // 2611
        public IEstado Estados { get; } // 2611
        public IMunicipio Municipios { get; } // 2611
        public IPais Paises { get; } // 2611
        public IProgramacion Programaciones { get; } // 2611
        public ITurno Turnos { get; } // 2611
        Task<int> SaveAsync(); // 2611
    }
}