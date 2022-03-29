using Phoneshop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Phoneshop.Data.Specifications.BrandSpecifications
{
    public class BrandIdSpecification : Specification<Brand>
    {
        private readonly int id;

        public BrandIdSpecification(int id)
        {
            this.id = id;
        }
        public override Expression<Func<Brand, bool>> ToExpression()
        {
            return b => b.Id == id;
        }
    }
}
