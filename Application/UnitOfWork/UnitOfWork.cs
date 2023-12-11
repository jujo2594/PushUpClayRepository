using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Repositories;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly contextSeguridad _context;
        private ICargo _cargos; // 2611
        private ICliente _clientes;
        private IContrato _contratos;
        private IDepartamento _departamentos;
        private IDireccionCliente _direccionClientes;
        private IDireccionEmpleado _direccionEmpleados;
        private IEmpleado _empleados;
        private IEstado _estados;
        private IMunicipio _municipios;
        private IPais _paises;
        private IProgramacion _programaciones;
        private ITurno _turnos;
        public UnitOfWork(contextSeguridad context) // 2611
        {
            _context = context;
        }

        public ICargo Cargos // 2611
        {
            get
            {
                if (_cargos == null)
                {
                    _cargos = new CargoRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _cargos;
            }
        }

        public ICliente Clientes // 2611
        {
            get
            {
                if (_clientes == null)
                {
                    _clientes = new ClienteRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _clientes;
            }
        }

        public IContrato Contratos // 2611
        {
            get
            {
                if (_contratos == null)
                {
                    _contratos = new ContratoRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _contratos;
            }
        }

        public IDepartamento Departamentos // 2611
        {
            get
            {
                if (_departamentos == null)
                {
                    _departamentos = new DepartamentoRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _departamentos;
            }
        }

        public IDireccionCliente DireccionClientes // 2611
        {
            get
            {
                if (_direccionClientes == null)
                {
                    _direccionClientes = new DireccionClienteRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _direccionClientes;
            }
        }

        public IDireccionEmpleado DireccionEmpleados // 2611
        {
            get
            {
                if (_direccionEmpleados == null)
                {
                    _direccionEmpleados = new DireccionEmpleadoRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _direccionEmpleados;
            }
        }

        public IEmpleado Empleados // 2611
        {
            get
            {
                if (_empleados == null)
                {
                    _empleados = new EmpleadoRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _empleados;
            }
        }

        public IEstado Estados // 2611
        {
            get
            {
                if (_estados == null)
                {
                    _estados = new EstadoRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _estados;
            }
        }

        public IMunicipio Municipios // 2611
        {
            get
            {
                if (_municipios == null)
                {
                    _municipios = new MunicipioRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _municipios;
            }
        }

        public IPais Paises // 2611
        {
            get
            {
                if (_paises == null)
                {
                    _paises = new PaisRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _paises;
            }
        }

        public IProgramacion Programaciones // 2611
        {
            get
            {
                if (_programaciones == null)
                {
                    _programaciones = new ProgramacionRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _programaciones;
            }
        }

        public ITurno Turnos // 2611
        {
            get
            {
                if (_turnos == null)
                {
                    _turnos = new TurnoRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _turnos;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public Task<int> SaveAsync() // 2611
        {
            return _context.SaveChangesAsync();
        }

        
    }
}