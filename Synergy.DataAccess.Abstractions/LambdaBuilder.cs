using System;
using System.Linq;
using System.Linq.Expressions;

using Microsoft.EntityFrameworkCore;

namespace Synergy.DataAccess.Abstractions
{
    public static class LambdaBuilder
    {
        public static Expression<Func<T, bool>> AndAlso<T>(this Expression<Func<T, bool>> predicate1, Expression<Func<T, bool>> predicate2)
        {
            ParameterExpression param = predicate1.Parameters[0];

            return Expression.Lambda<Func<T, bool>>(
                Expression.AndAlso(predicate1.Body, Expression.Invoke(predicate2, param)),
                param);
        }

        public static Expression<Func<T, bool>> OrElse<T>(this Expression<Func<T, bool>> predicate1, Expression<Func<T, bool>> predicate2)
        {
            ParameterExpression param = predicate1.Parameters[0];

            return Expression.Lambda<Func<T, bool>>(
                Expression.OrElse(predicate1.Body, Expression.Invoke(predicate2, param)),
                param);
        }

        public static IQueryable<T> IncludeMultiple<T>(this IQueryable<T> query, params Expression<Func<T, object>>[] includes)
            where T : class
        {
            if (includes != null)
            {
                query = includes.Aggregate(query,
                          (current, include) => current.Include(include));
            }

            return query;
        }

        public static IQueryable<T> ApplyPaging<T>(this IQueryable<T> query, int? skip, int? take)
            where T : class
        {
            if (skip != null)
            {
                query = query.Skip((int)skip);
            }

            if (take != null)
            {
                query = query.Take((int)take);
            }

            return query;
        }

        public static IQueryable<T> OrderBy<T>(this IQueryable<T> query, Expression<Func<T, object>> sortSelector, bool isAsc)
            where T : class
        {
            if (sortSelector == null)
            {
                return query;
            }

            if (isAsc)
            {
                return query.OrderBy(sortSelector);
            }

            return query.OrderByDescending(sortSelector);
        }
    }
}
