using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoneshop.Data.Entities
{
    public class Brand:Base
    {
        [Required]
        public string Name { get; set; }
        public ICollection<Phone> Phones { get; set; }
    }
}
