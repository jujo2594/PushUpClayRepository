using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repositories
{
    public class MunicipioRepository : GenericRepository<Municipio>, IMunicipio
    {
        public MunicipioRepository(contextSeguridad context) : base(context)
        {
        }
    }
}