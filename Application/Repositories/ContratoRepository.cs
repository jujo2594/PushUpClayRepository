using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repositories
{
    public class ContratoRepository : GenericRepository<Contrato>, IContrato
    {
        public ContratoRepository(contextSeguridad context) : base(context)
        {
        }
    }
}