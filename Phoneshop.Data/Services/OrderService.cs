using Phoneshop.Data.Entities;
using Phoneshop.Data.Interfaces;
using Phoneshop.Data.Specifications;
using Phoneshop.Data.Specifications.OrderSpecifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoneshop.Data.Services
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> repo;

        public OrderService(IRepository<Order> repo)
        {
            this.repo = repo;
        }
        public Order Create(Order order)
        {
            return repo.Create(order);
        }

        public Order Delete(int id)
        {
            var spec = new OrderIdSpecification(id);
            var entity = repo.Get(spec);
            entity.Deleted = true;
            return repo.Update(entity);
        }

        public IEnumerable<Order> Get(bool deleted, DateTime from, DateTime to, int id =0)
        {
            Specification<Order> spec = new OrderDateSpecification(from, to);
            if (deleted)
                spec = spec.And(new OrderDeletedSpecification());
            if (id != 0)
            {
                spec = spec.And(new UserIdOrderSpecification(id));
            }


            return repo.GetSet(spec);
        }
    }
}
