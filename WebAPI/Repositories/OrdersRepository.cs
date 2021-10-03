using EntityDB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Repositories
{
    public class OrdersRepository : IOrdersService
    {
        private readonly NORTHWNDContext _context;
        
        public OrdersRepository(NORTHWNDContext context)
        {
            _context= context;
        }
   
        public async Task<List<Order>> Get()
        {
            _context.ChangeTracker.LazyLoadingEnabled = false;
            _context.ChangeTracker.AutoDetectChangesEnabled = false;
            var q = await _context.Set<Order>()
                .Include(x => x.OrderDetails)
                .ThenInclude(x => x.Product)
                .ThenInclude(x => x.Category)
                .ToListAsync();
            return q;
        }

    }
}
