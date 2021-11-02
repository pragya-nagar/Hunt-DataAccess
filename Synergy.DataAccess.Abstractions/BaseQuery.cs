using System;
using System.Collections.Generic;
using System.Linq.Expressions;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Abstractions
{
    public abstract class BaseQuery<T>
        where T : IEntity
    {
        protected List<Expression<Func<T, bool>>> andAlsoPredicates = new List<Expression<Func<T, bool>>>();
        protected List<Expression<Func<T, object>>> includes = new List<Expression<Func<T, object>>>();
        protected int? _skip;
        protected int? _take;

        protected Expression<Func<T, object>> _sortSelector;
        protected bool _isSortAsc;

        protected Expression<Func<T, bool>> GetPredicate()
        {
            Expression<Func<T, bool>> buildedPredicate = e => true;

            foreach (var predicate in andAlsoPredicates)
            {
                buildedPredicate = buildedPredicate.AndAlso(predicate);
            }

            return buildedPredicate;
        }
    }
}
