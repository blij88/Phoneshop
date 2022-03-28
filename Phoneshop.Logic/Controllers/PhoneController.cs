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
        public Phone Create(Phone phone)
        {
            return phoneService.Create(phone);
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
