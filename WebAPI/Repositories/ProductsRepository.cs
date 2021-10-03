using EntityDB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unipluss.Sign.ExternalContract.Entities;

namespace WebAPI.Repositories
{
    public class ProductsRepository : IProductsService
    {
        private readonly NORTHWNDContext _context;
        public ProductsRepository(NORTHWNDContext context)
        {
            _context = context;
        }

   
        public List<Product> Get()
        {
            var q = _context.Set<EntityDB.Models.Product>().Include(x => x.Supplier).AsQueryable().ToList();
            return q;
        }
    }
}
