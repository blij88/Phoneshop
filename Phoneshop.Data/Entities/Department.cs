using System.Collections.Generic;

namespace Phoneshop.Data.Entities
{
    public class Department:Base
    {
        public string Name { get; set; }
        public IList<User> Users { get; set; }
    }
}