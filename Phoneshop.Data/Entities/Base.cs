using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoneshop.Data.Entities
{
    public class Base
    {
        public int Id { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime UpdateDateTime { get; set; }

        public Base()
        {
            CreateDateTime = DateTime.Now;
        }
    }
}
