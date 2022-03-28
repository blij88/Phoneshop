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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Phone>().HasOne(p => p.Brand).WithMany(b => b.Phones);
            modelBuilder.Seed();
        }

    }
}
