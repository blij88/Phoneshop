using System;
using System.Linq;
using System.Linq.Expressions;

namespace Phoneshop.Data.Specifications
{
    public abstract class Specification<T>
    {
        public bool IsSatisfied(T entity)
        {
            Func<T, bool> predicate = ToExpression().Compile();
            return predicate(entity);
        }
        public abstract Expression<Func<T, bool>> ToExpression();

        public Specification<T> And(Specification<T> specification)
        {
            return new AndSpecification<T>(this, specification);
        }
        public Specification<T> Or(Specification<T> specification)
        {
            return new OrSpecification<T>(this, specification);
        }
        public Specification<T> Not()
        {
            return new NotSpecification<T>(this);
        }
    }

    internal sealed class AndSpecification<T> :  Specification<T>
    {
        private readonly Specification<T> right;
        private readonly Specification<T> left;

        public AndSpecification(Specification<T> left, Specification<T> right)
        {
            this.right = right;
            this.left = left;
        }

        public override Expression<Func<T, bool>> ToExpression()
        {
            var leftExpression = left.ToExpression();
            var rightExpression = right.ToExpression();

            var andExpression = Expression.AndAlso(leftExpression.Body, rightExpression.Body);

            return Expression.Lambda<Func<T,bool>>(andExpression, Expression.Parameter(typeof(T)));
        }
    }
    internal sealed class OrSpecification<T> : Specification<T>
    {
        private readonly Specification<T> right;
        private readonly Specification<T> left;

        public OrSpecification(Specification<T> left, Specification<T> right)
        {
            this.right = right;
            this.left = left;
        }

        public override Expression<Func<T, bool>> ToExpression()
        {
            var leftExpression = left.ToExpression();
            var rightExpression = right.ToExpression();

            var orExpression = Expression.OrElse(leftExpression.Body, rightExpression.Body);

            return Expression.Lambda<Func<T, bool>>(orExpression, Expression.Parameter(typeof(T)));
        }
    }
    internal sealed class NotSpecification<T> : Specification<T>
    {
        private readonly Specification<T> specification;

        public NotSpecification(Specification<T> specification)
        {
            this.specification = specification;
        }

        public override Expression<Func<T, bool>> ToExpression()
        {
            var expression = specification.ToExpression();

            var andExpression = Expression.Not(expression.Body);

            return Expression.Lambda<Func<T, bool>>(andExpression, expression.Parameters.Single());
        }
    }

    }
