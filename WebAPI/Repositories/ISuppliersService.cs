using EntityDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Repositories
{
    public  interface ISuppliersService
    {
            Task<IEnumerable<Supplier>> Get();
    }
}
