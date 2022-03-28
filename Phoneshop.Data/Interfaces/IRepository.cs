using Phoneshop.Data.Specifications;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Phoneshop.Data.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetSet(Specification<T> spec);
        T Get(Specification<T> spec);
        T Update(T entity);
        T Create(T entity);
    }
}
