using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repositories
{
    public class EstadoRepository : GenericRepository<Estado>, IEstado
    {
        public EstadoRepository(contextSeguridad context) : base(context)
        {
        }
    }
}