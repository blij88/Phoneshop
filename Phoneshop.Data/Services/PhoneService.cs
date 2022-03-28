using Phoneshop.Data.Entities;
using Phoneshop.Data.Interfaces;
using Phoneshop.Data.Specifications;
using Phoneshop.Data.Specifications.PhoneSpecifications;

namespace Phoneshop.Data.Services
{
    public class PhoneService : IPhoneService
    {
        private readonly IRepository<Phone> ef;

        public PhoneService(IRepository<Phone> ef)
        {
            this.ef = ef;
        }

        public Phone Action(int id, int type, double value)
        {
            var idspec = new PhoneIdSpecification(id);            
            var phone = ef.Get(idspec);
            if (phone != null)
            {
                var update = new PhoneUpdate() { Discount = value, DiscountType = type };
                return Update(update);
            }
            return null;
        }

        public Phone Create(Phone phone)
        {
            var PhoneBrandId = new PhoneBrandSpecification(phone.BrandId);
            var phoneType = new PhoneTypeSpecification(phone.Type);
            var spec = phoneType.And(PhoneBrandId);
            if (ef.Get(spec) == null)
            {
                return ef.Create(phone);
            }
            return null;
        }

        public Phone Delete(int id)
        {
            var idspec = new PhoneIdSpecification(id);
            var phone = ef.Get(idspec);
            phone.Deleted = true;
            ef.Update(phone);
            return phone;
        }

        public Phone Update(PhoneUpdate update)
        {
            var idspec = new PhoneIdSpecification(update.PhoneId);
            var phone = ef.Get(idspec);
            if (phone != null)
            {
                phone.Color = update.Color;
                phone.Camera = update.Camera;
                phone.Image = update.Image;
                phone.Price = update.Price;
                phone.Processor = update.Prosessor;
                phone.ScreenResolution = update.ScreenResolution;
                phone.DiscountType = update.DiscountType;
                phone.Discount = update.Discount;
                phone.Description = update.Description;
                return ef.Update(phone);
            }
            return null;
        }
    }
}
