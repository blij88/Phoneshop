using Phoneshop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoneshop.Data.Interfaces
{
    public interface IPhoneService
    {
        Phone Create(Phone phone);
        Phone Update(Phone phone);
        Phone Delete(int id);
        Phone Action(int id, int type, double value);
    }
}
