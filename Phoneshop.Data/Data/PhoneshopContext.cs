using Microsoft.EntityFrameworkCore;
using Phoneshop.Data.Entities;

namespace Phoneshop.Data.Data
{
    public class PhoneshopContext : DbContext
    {
        public PhoneshopContext(DbContextOptions<PhoneshopContext> options) : base(options)
        {

        }
        public DbSet<Phone> phones { get; set; }
        public DbSet<Brand> brands { get; set; }
        public DbSet<Order> orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductsPerOrder>()
                .HasKey(pp => new { pp.OrderId, pp.PhoneId });
            modelBuilder.Entity<ProductsPerOrder>()
                .HasOne(pp => pp.Phone)
                .WithMany(P => P.ProductsPerOrders)
                .HasForeignKey(pp => pp.PhoneId);
            modelBuilder.Entity<ProductsPerOrder>()
                .HasOne(pp => pp.Order)
                .WithMany(o => o.ProductsPerOrder)
                .HasForeignKey(bc => bc.OrderId);

            modelBuilder.Entity<Phone>()
                .HasOne(p => p.Brand)
                .WithMany(b => b.Phones);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.User)
                .WithMany(u => u.Orders);

            modelBuilder.Seed();
        }

    }
}
