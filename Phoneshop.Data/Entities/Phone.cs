using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoneshop.Data.Entities
{
    public class Phone:Base
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        [Required]
        public Double Price { get; set; }
        [Required]
        public string Color { get; set; }
        public string Camera { get; set; }
        public string Processor { get; set; }
        public string ScreenResolution { get; set; }
        public double Discount { get; set; }
        public int DiscountType { get; set; }
        [Required]
        public string Description { get; set; }
        public bool Deleted { get; set; } = false;
        public string Image { get; set; }
        public IList<ProductsPerOrder> Products { get; set; }
    }
}
