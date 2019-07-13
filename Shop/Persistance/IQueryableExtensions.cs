using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Shop.Persistance
{
    public static class IQueryableExtensions
    {
        public static IQueryable<TEntity> IncludeIf<TEntity, TProperty>(
            this IQueryable<TEntity> source,
            Expression<Func<TEntity, TProperty>> navigationPropertyPath,
            bool condition) where TEntity : class
        {
            return condition ? source.Include(navigationPropertyPath) : source;
        }
    }
}