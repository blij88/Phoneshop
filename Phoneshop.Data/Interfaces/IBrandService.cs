using Phoneshop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoneshop.Data.Interfaces
{
    public interface IBrandService
    {
        Brand Create(Brand brand);
        Brand Update(Brand brand);
        Brand Delete(Brand brand);
        Brand GetById(int id);
        IEnumerable<Brand> Get();
    }
}
