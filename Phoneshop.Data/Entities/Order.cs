using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoneshop.Data.Entities
{
    public class Order:Base
    {
        public int CustomerId { get; set; }
        public User User { get; set; }
        public double TotalPrice { get; set; }
        public double VatPercentage { get; set; }
        public DateTime OrderDate { get; set; }
        public IList<ProductsPerOrder> ProductsPerOrder { get; set; }
        public bool Deleted { get; set; } = false;
        public int Reason { get; set; }
    }
}
