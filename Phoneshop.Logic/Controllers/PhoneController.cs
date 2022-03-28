using Microsoft.AspNetCore.Http;
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
        public ObjectResult Create(Phone phone)
        {
            var result = phoneService.Create(phone);
            if (result != null)
                return Ok(result);
            return BadRequest("something went wrong");
        }

        [HttpPut]
        public Phone Update(PhoneUpdate update)
        {
            return phoneService.Update(update);
        }

        [HttpPut("discount")]
        public Phone discount(int id,int type, double value )
        {
            return phoneService.Action(id,type,value);
        }

        [HttpDelete("{id}")]
        public Phone Delete(int id)
        {
           return phoneService.Delete(id);
        }
    }
}
