using Microsoft.EntityFrameworkCore;
using Phoneshop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoneshop.Data.Data
{
    public static class DataSeed
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Phone>().HasData(
                new Phone { Id = 1, BrandId = 1, Price = 54.00, Description = "testing", Type = "test1", Color = "blood" },
                new Phone { Id = 2, BrandId = 2, Price = 54.00, Description = "testing", Type = "test2", Color = "blood" },
                new Phone { Id = 3, BrandId = 1, Price = 54.00, Description = "testing", Type = "test3", Color = "blood" },
                new Phone { Id = 4, BrandId = 2, Price = 54.00, Description = "testing", Type = "test4", Color = "blood" },
                new Phone { Id = 5, BrandId = 1, Price = 54.00, Description = "testing", Type = "test5", Color = "blood" }
                );
            modelBuilder.Entity<Phone>().Property(p => p.Price).HasConversion<decimal>();
            modelBuilder.Entity<Brand>().HasData(
                new Brand { Id = 1, Name = "Motorola" },
                new Brand { Id = 2, Name = "Xiaomi" }
                );
        }
    }
}
