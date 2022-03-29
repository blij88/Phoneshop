using Phoneshop.Data.Entities;
using Phoneshop.Data.Interfaces;
using Phoneshop.Data.Specifications.BrandSpecifications;
using Phoneshop.Data.Specifications.PhoneSpecifications;

namespace Phoneshop.Data.Services
{
    public class PhoneService : IPhoneService
    {
        private readonly IRepository<Phone> ef;
        private readonly IRepository<Brand> brandef;

        public PhoneService(IRepository<Phone> ef, IRepository<Brand> brandef)
        {
            this.ef = ef;
            this.brandef = brandef;
        }

        public Phone Action(int id, int type, double value)
        {
            var idspec = new PhoneIdSpecification(id);
            var phone = ef.Get(idspec);
            if (phone != null)
            {
                phone.DiscountType = type;
                phone.Discount = value;
                return ef.Update(phone);
            }
            return null;
        }

        public Phone Create(Phone phone)
        {
            var BrandIdspec = new BrandIdSpecification(phone.BrandId);
            if (brandef.Get(BrandIdspec) == null)
            {
                phone.Type = "no such Brand Exists";
                return phone;
            }
            var PhoneBrandId = new PhoneBrandSpecification(phone.BrandId);
            var phoneType = new PhoneTypeSpecification(phone.Type);
            var spec = phoneType.And(PhoneBrandId);
            if (ef.Get(spec) == null)
            {
                return ef.Create(phone);
            }
            phone.Type = "phone already exists";
            return phone;
        }

        public Phone Delete(int id)
        {
            var idspec = new PhoneIdSpecification(id);
            var phone = ef.Get(idspec);
            phone.Deleted = true;
            ef.Update(phone);
            return phone;
        }

        public Phone Update(Phone phone)
        {

            var idspec = new PhoneIdSpecification(phone.Id);
            var old = ef.Get(idspec);
            if (phone.Color == null || phone.Description == null)
            {
                return null;
            }
            old.Color = phone.Color;
            old.Description = phone.Description;
            old.Camera = phone.Camera;
            old.Description = phone.Description;
            old.Discount = phone.Discount;
            old.DiscountType = phone.DiscountType;
            old.Image = phone.Image;
            old.Processor = phone.Processor;
            old.ScreenResolution = phone.ScreenResolution;
                return ef.Update(old);
        }
    }
}
