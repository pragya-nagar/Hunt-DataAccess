using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using AutoMapper;

using Microsoft.EntityFrameworkCore;

using Synergy.DataAccess.Abstractions;
using Synergy.DataAccess.Context;
using Synergy.DataAccess.Dictionaries.Queries.Interfaces;
using Synergy.DataAccess.Dictionaries.Queries.Models;
using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Dictionaries.Queries.Queries
{
    public class GetCampaignTypesQuery : BaseQuery<CampaignType>, IGetCampaignTypesQuery
    {
        private IMapper _mapper;
        private DbSet<CampaignType> _entity;

        public GetCampaignTypesQuery(ISynergyContext context, IMapper mapper)
        {
            _mapper = mapper;
            _entity = context.CampaignType;
        }

        public int? TotalCount { get; private set; }

        public IGetCampaignTypesQuery FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public IGetCampaignTypesQuery Search(string search)
        {
            if (string.IsNullOrEmpty(search))
            {
                return this;
            }

            search = search.Trim().ToLower();
            andAlsoPredicates.Add(x => x.Name.ToLower().StartsWith(search) || x.Description.ToLower().StartsWith(search));

            return this;
        }

        public IEnumerable<CampaignTypeModel> Exeсute()
        {
            IQueryable<CampaignType> data = BuildQuery();
            return _mapper.Map<IEnumerable<CampaignTypeModel>>(data);
        }

        public async Task<IEnumerable<CampaignTypeModel>> ExeсuteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            IQueryable<CampaignType> data = BuildQuery();
            return _mapper.Map<IEnumerable<CampaignTypeModel>>(await data.ToListAsync(cancellationToken).ConfigureAwait(false));
        }

        private IQueryable<CampaignType> BuildQuery()
        {
            // Get only parent items
            andAlsoPredicates.Add(ct => ct.ParentTypeId == null);
            includes.Add(ct => ct.ChaildTypes);

            IQueryable<CampaignType> query = _entity
                .IncludeMultiple(includes.ToArray())
                .Where(GetPredicate())
                .ApplyPaging(_skip, _take);

            return query;
        }
    }
}
