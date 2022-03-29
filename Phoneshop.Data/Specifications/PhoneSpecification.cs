using Phoneshop.Data.Entities;
using System;
using System.Linq.Expressions;

namespace Phoneshop.Data.Specifications.PhoneSpecifications
{
    public sealed class PhoneIdSpecification : Specification<Phone>
    {
        private readonly int id;
        public PhoneIdSpecification(int id)
        {
            this.id = id;
        }
        public override Expression<Func<Phone, bool>> ToExpression()
        {
            return p => p.Id == id;
        }
    }

    public sealed class PhoneBrandSpecification : Specification<Phone>
    {
        private readonly int brandId;
        public PhoneBrandSpecification(int BrandId)
        {
            this.brandId = BrandId;
        }
        public override Expression<Func<Phone, bool>> ToExpression()
        {
            return  p => p.BrandId == brandId;
        }
    }

    public sealed class PhoneTypeSpecification : Specification<Phone>
    {
        private readonly string type;
        public PhoneTypeSpecification(string Type)
        {
            this.type = Type;
        }
        public override Expression<Func<Phone, bool>> ToExpression()
        {
            return p => p.Type == type;
        }
    }



}
