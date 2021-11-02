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
    public class GetGeneralLandUseCodesQuery : BaseQuery<GeneralLandUseCode>, IGetGeneralLandUseCodesQuery
    {
        private IMapper _mapper;
        private DbSet<GeneralLandUseCode> _entity;

        public GetGeneralLandUseCodesQuery(ISynergyContext context, IMapper mapper)
        {
            _mapper = mapper;
            _entity = context.GeneralLandUseCode;
        }

        public int? TotalCount { get; private set; }

        #region query builder

        public IGetGeneralLandUseCodesQuery FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public IGetGeneralLandUseCodesQuery Skip(int skip)
        {
            _skip = skip;
            return this;
        }

        public IGetGeneralLandUseCodesQuery Take(int take)
        {
            _take = take;
            return this;
        }

        public IGetGeneralLandUseCodesQuery Search(string search)
        {
            if (string.IsNullOrEmpty(search))
            {
                return this;
            }

            search = search.Trim().ToLower();
            andAlsoPredicates.Add(x => x.Name.ToLower().StartsWith(search));

            return this;
        }
        #endregion

        public IEnumerable<FastEntityModel<int>> Exeсute()
        {
            IEnumerable<GeneralLandUseCode> data = BuildQuery();

            if (_skip != null || _take != null)
            {
                TotalCount = _entity.Where(GetPredicate()).Count();
            }

            return _mapper.Map<IEnumerable<FastEntityModel<int>>>(data);
        }

        public async Task<IEnumerable<FastEntityModel<int>>> ExeсuteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            IQueryable<GeneralLandUseCode> data = BuildQuery();

            if (_skip != null || _take != null)
            {
                TotalCount = await _entity.Where(GetPredicate()).CountAsync(cancellationToken).ConfigureAwait(false);
            }

            return _mapper.Map<IEnumerable<FastEntityModel<int>>>(await data.ToListAsync(cancellationToken).ConfigureAwait(false));
        }

        private IQueryable<GeneralLandUseCode> BuildQuery()
        {
            IQueryable<GeneralLandUseCode> query = _entity
                .Where(GetPredicate())
                .ApplyPaging(_skip, _take);

            return query;
        }
    }
}
