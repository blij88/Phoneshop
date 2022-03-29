using Microsoft.AspNetCore.Mvc;
using Phoneshop.Data.Entities;
using Phoneshop.Data.Interfaces;

namespace Phoneshop.Logic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhoneController : ControllerBase
    {
        private readonly IPhoneService phoneService;

        public PhoneController(IPhoneService phoneService)
        {
            this.phoneService = phoneService;
        }
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Create(Phone phone)
        {
            var type = phone.Type;
            var result = phoneService.Create(phone);
            if (result.Type == type)
                return Ok(result);
            return BadRequest(phone.Type);
        }

        [HttpPut]
        public IActionResult Update(Phone update)
        {
            var result = phoneService.Update(update);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("update could not be created");
        }

        [HttpPut("discount")]
        public IActionResult discount(int id, int type, double value)
        {
            var result = phoneService.Action(id, type, value);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("discount could not be implemented");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(phoneService.Delete(id));
        }
    }
}
