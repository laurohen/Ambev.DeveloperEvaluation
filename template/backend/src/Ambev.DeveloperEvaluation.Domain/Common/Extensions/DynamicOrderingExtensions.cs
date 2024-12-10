using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Common.Extensions
{
    /// <summary>
    /// Extension methods for dynamic ordering.
    /// </summary>
    public static class DynamicOrderingExtensions
    {
        public static IQueryable<T> OrderByDynamic<T>(this IQueryable<T> source, string propertyName)
        {
            var parameter = Expression.Parameter(typeof(T), "x");
            var property = Expression.Property(parameter, propertyName);
            var selector = Expression.Lambda(property, parameter);
            return source.Provider.CreateQuery<T>(
                Expression.Call(typeof(Queryable), "OrderBy", new Type[] { typeof(T), property.Type }, source.Expression, selector));
        }

        public static IQueryable<T> OrderByDescendingDynamic<T>(this IQueryable<T> source, string propertyName)
        {
            var parameter = Expression.Parameter(typeof(T), "x");
            var property = Expression.Property(parameter, propertyName);
            var selector = Expression.Lambda(property, parameter);
            return source.Provider.CreateQuery<T>(
                Expression.Call(typeof(Queryable), "OrderByDescending", new Type[] { typeof(T), property.Type }, source.Expression, selector));
        }
    }
}
