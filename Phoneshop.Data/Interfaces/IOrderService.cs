using Phoneshop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoneshop.Data.Interfaces
{
    public interface IOrderService
    {
        Order Create(Order order);
        Order Delete(int id, reason reason);
        IEnumerable<Order> Get(bool deleted, DateTime from, DateTime to, int id);
    }
}
