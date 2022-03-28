using Microsoft.EntityFrameworkCore;
using Phoneshop.Data.Data;
using Phoneshop.Data.Interfaces;
using Phoneshop.Data.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Phoneshop.Data.Repositories
{
    public class EFRepository<T> : IRepository<T> where T : class
    {
        private readonly PhoneshopContext db;

        public EFRepository(PhoneshopContext db)
        {
            this.db = db;
        }

        public T Create(T entity)
        {
            db.Add<T>(entity);
            db.SaveChanges();
            return entity;
        }

        public IEnumerable<T> GetSet(Specification<T> spec)
        {
            return db.Set<T>().Where(spec.ToExpression()).ToList();
        }


        public T Get(Specification<T> spec)
        {
            return db.Set<T>().FirstOrDefault(spec.ToExpression());
        }

        public T Update(T entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
            return entity;
        }
    }
}
