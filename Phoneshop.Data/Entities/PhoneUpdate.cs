using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoneshop.Data.Entities
{
    public class PhoneUpdate
    {
        public int PhoneId { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string Color { get; set; }
        public string Camera { get; set; }
        public string Prosessor { get; set; }
        public string ScreenResolution { get; set; }
        public double Discount { get; set; }
        public int DiscountType { get; set; }
        [Required]
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
