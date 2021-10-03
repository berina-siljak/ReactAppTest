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
    public class OrdersController : ControllerBase
    {
        private readonly IOrdersService _ordersService;

        public OrdersController(IOrdersService order)
        {
            _ordersService = order;
        }

        [HttpGet]
        public async Task<List<OrdersViewModel>> Get()
        {
            return (await _ordersService.Get()).Select(x => new OrdersViewModel(x)).ToList();
        }
    }
}
