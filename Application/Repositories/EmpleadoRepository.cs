using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.Identity.Client;
using Persistence.Data;

namespace Application.Repositories
{
    public class EmpleadoRepository : GenericRepository<Empleado>, IEmpleado
    {
        public EmpleadoRepository(contextSeguridad context) : base(context)
        {
        }
    }
}