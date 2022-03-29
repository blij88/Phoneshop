using Phoneshop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Phoneshop.Data.Specifications.OrderSpecifications
{
    public sealed class OrderDeletedSpecification : Specification<Order>
    {
        public override Expression<Func<Order, bool>> ToExpression()
        {
            return o => o.Deleted == false;
        }
    }

    public sealed class UserIdOrderSpecification : Specification<Order>
    {
        private readonly int id;

        public UserIdOrderSpecification(int id)
        {
            this.id = id;
        }

        public override Expression<Func<Order, bool>> ToExpression()
        {
            return o => o.User.Id == id;
        }
    }

    public sealed class OrderDateSpecification : Specification<Order>
    {
        private readonly DateTime from;
        private readonly DateTime to;

        public OrderDateSpecification(DateTime from, DateTime to)
        {
            this.from = from;
            this.to = to;
        }


        public override Expression<Func<Order, bool>> ToExpression()
        {
            return o => o.CreateDateTime > from && o.CreateDateTime < to;
        }
    }

    public sealed class OrderIdSpecification : Specification<Order>
    {
        private readonly int id;

        public OrderIdSpecification(int id)
        {
            this.id = id;
        }

        public override Expression<Func<Order, bool>> ToExpression()
        {
            return o => o.Id == id;
        }
    }
}
