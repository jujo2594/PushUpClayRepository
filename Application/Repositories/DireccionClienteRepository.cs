using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repositories
{
    public class DireccionClienteRepository : GenericRepository<DireccionCliente>, IDireccionCliente
    {
        public DireccionClienteRepository(contextSeguridad context) : base(context)
        {
        }
    }
}