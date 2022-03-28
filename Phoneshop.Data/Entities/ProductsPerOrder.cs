namespace Phoneshop.Data.Entities
{
    public class ProductsPerOrder
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int Id { get; set; }
        public Phone Phone { get; set; }
    }
}