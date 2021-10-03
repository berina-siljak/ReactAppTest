using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using WebAPI.Repositories;
using EntityDB.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase   
    {
        private readonly IProductsService _productsService;
        public ProductsController(IProductsService product)
        {
            _productsService = product;

        }
        [HttpGet]
    

        [HttpGet]
        public List<Product> Get()
        {
            return _productsService.Get();
        }

    }
}
