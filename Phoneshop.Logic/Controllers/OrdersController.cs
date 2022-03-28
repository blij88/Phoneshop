using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Phoneshop.Data.Entities;

namespace Phoneshop.Logic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        public OrdersController()
        {

        }
        [HttpPost]
        public IActionResult Create(Order order)
        {
            throw new System.NotImplementedException();
        }
    }
}
