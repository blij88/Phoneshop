using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Phoneshop.Data.Entities;
using Phoneshop.Data.Interfaces;

namespace Phoneshop.Logic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService order;

        public OrdersController(IOrderService orderService)
        {
            this.order = orderService;
        }
        [HttpPost]
        public IActionResult Create(Order order)
        {
            
            return Ok(order);
        }
    }
}
