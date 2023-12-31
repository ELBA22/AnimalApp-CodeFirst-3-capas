using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infraestructure.Data;
using Infraestructure.Repositories;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class DepartamentoRepository : GenericRepository<Departamento>, IDepartamentoRepository
    {
        private readonly AnimalsContext _context;

        public DepartamentoRepository(AnimalsContext context) : base(context)
        {
            _context = context;
        }
    }
}