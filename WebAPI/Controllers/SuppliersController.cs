using EntityDB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Repositories;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController : ControllerBase
    {
         private readonly ISuppliersService _suppliersService;
        public SuppliersController(ISuppliersService supplier)
        {
            _suppliersService = supplier;

        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Supplier>>> Get()
        {
            var list = await _suppliersService.Get();
            return Ok(list);
        }
    }
}
