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
            modelBuilder.Seed();
        }

    }
}
