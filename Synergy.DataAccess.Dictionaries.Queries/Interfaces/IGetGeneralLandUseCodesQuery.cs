using System.Collections.Generic;

using Synergy.DataAccess.Abstractions.Interfaces;
using Synergy.DataAccess.Abstractions.Models;

namespace Synergy.DataAccess.Dictionaries.Queries.Interfaces
{
    public interface IGetGeneralLandUseCodesQuery : IQuery<IGetGeneralLandUseCodesQuery, IEnumerable<FastEntityModel<int>>>,
                                                     IHavePagination<IGetGeneralLandUseCodesQuery>,
                                                     IHaveSearch<IGetGeneralLandUseCodesQuery>
    {
    }
}
