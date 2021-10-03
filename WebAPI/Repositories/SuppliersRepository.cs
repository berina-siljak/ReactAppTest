using EntityDB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Repositories
{
    public class SuppliersRepository : ISuppliersService
    {
        private readonly NORTHWNDContext _context;
        public SuppliersRepository(NORTHWNDContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Supplier>> Get()
        {
            return await _context.Suppliers.ToListAsync();
        }
    }
}
