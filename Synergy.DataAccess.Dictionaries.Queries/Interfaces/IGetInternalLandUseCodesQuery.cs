using System.Collections.Generic;

using Synergy.DataAccess.Abstractions.Interfaces;
using Synergy.DataAccess.Abstractions.Models;

namespace Synergy.DataAccess.Dictionaries.Queries.Interfaces
{
    public interface IGetInternalLandUseCodesQuery : IQuery<IGetInternalLandUseCodesQuery, IEnumerable<FastEntityModel<int>>>,
                                                     IHavePagination<IGetInternalLandUseCodesQuery>,
                                                     IHaveSearch<IGetInternalLandUseCodesQuery>
    {
    }
}
