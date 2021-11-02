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
    public class GetPropertyDisplayStrategiesDictionaryQuery : BaseQuery<PropertyDisplayStrategy>, IGetPropertyDisplayStrategiesDictionaryQuery
    {
        private IMapper _mapper;
        private DbSet<PropertyDisplayStrategy> _entity;

        public GetPropertyDisplayStrategiesDictionaryQuery(ISynergyContext context, IMapper mapper)
        {
            _mapper = mapper;
            _entity = context.PropertyDisplayStrategy;
        }

        public IGetPropertyDisplayStrategiesDictionaryQuery FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FastEntityModel<int>> Exeсute()
        {
            return _mapper.Map<IEnumerable<FastEntityModel<int>>>(_entity.Where(GetPredicate()));
        }

        public async Task<IEnumerable<FastEntityModel<int>>> ExeсuteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            return _mapper.Map<IEnumerable<FastEntityModel<int>>>(await _entity.Where(GetPredicate()).ToListAsync(cancellationToken).ConfigureAwait(false));
        }
    }
}
