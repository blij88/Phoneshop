namespace Phoneshop.Data.Entities
{
    public class ProductsPerOrder:Base
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int PhoneId { get; set; }
        public Phone Phone { get; set; }
    }
}