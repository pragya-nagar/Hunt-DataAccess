using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using AutoMapper;

using Microsoft.EntityFrameworkCore;

using Synergy.DataAccess.Abstractions;
using Synergy.DataAccess.Abstractions.Models;
using Synergy.DataAccess.Context;
using Synergy.DataAccess.Dictionaries.Queries.Interfaces;
using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Dictionaries.Queries.Queries
{
    public class GetUsersDictionaryQuery : BaseQuery<User>, IGetUsersDictionaryQuery
    {
        private IMapper _mapper;
        private DbSet<User> _entity;

        public GetUsersDictionaryQuery(ISynergyContext context, IMapper mapper)
        {
            _mapper = mapper;
            _entity = context.User;
        }

        public int? TotalCount { get; private set; }

        #region query builder
        public IGetUsersDictionaryQuery FindById(Guid id)
        {
            andAlsoPredicates.Add(u => u.Id == id);
            return this;
        }

        public IGetUsersDictionaryQuery Skip(int skip)
        {
            _skip = skip;
            return this;
        }

        public IGetUsersDictionaryQuery Take(int take)
        {
            _take = take;
            return this;
        }

        public IGetUsersDictionaryQuery Search(string search)
        {
            if (string.IsNullOrEmpty(search))
            {
                return this;
            }

            var trim = System.Text.RegularExpressions.Regex.Replace(search.Trim(), "\\s+", " ");
            var parts = trim.ToLower().Split(' ');

            parts.Aggregate(andAlsoPredicates,
                     (current, part) =>
                     {
                         current.Add(x => x.FirstName.ToLower().StartsWith(part) ||
                                          x.LastName.ToLower().StartsWith(part) ||
                                          x.Email.ToLower().Contains(trim));
                         return current;
                     });

            return this;
        }
        #endregion

        public IEnumerable<FastEntityModel<Guid>> Exeсute()
        {
            IQueryable<User> data = BuildQuery();

            if (_skip != null || _take != null)
            {
                TotalCount = _entity.Where(GetPredicate()).Count();
            }

            return Convert(data.ToList());
        }

        public async Task<IEnumerable<FastEntityModel<Guid>>> ExeсuteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            IQueryable<User> data = BuildQuery();

            if (_skip != null || _take != null)
            {
                TotalCount = await _entity.Where(GetPredicate()).CountAsync(cancellationToken).ConfigureAwait(false);
            }

            // return _mapper.Map<IEnumerable<FastEntityModel<Guid>>>(await data.ToListAsync(cancellationToken));
            return Convert(await data.ToListAsync(cancellationToken).ConfigureAwait(false));
        }

        private IQueryable<User> BuildQuery()
        {
            IQueryable<User> query = _entity
                .Where(GetPredicate())
                .ApplyPaging(_skip, _take);

            return query;
        }

        private List<FastEntityModel<Guid>> Convert(List<User> data)
        {
            return data.Select(u => new FastEntityModel<Guid> { Id = u.Id, Name = $"{u.FirstName} {u.LastName}" }).ToList();
        }
    }
}
