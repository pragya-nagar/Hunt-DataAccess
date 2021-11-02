using System.Collections.Generic;

using Synergy.DataAccess.Abstractions.Interfaces;
using Synergy.DataAccess.Abstractions.Models;

namespace Synergy.DataAccess.Dictionaries.Queries.Interfaces
{
    public interface IGetStatesDictionaryQuery : IQuery<IGetStatesDictionaryQuery, IEnumerable<FastEntityModel<int>>>,
                                                 IHavePagination<IGetStatesDictionaryQuery>,
                                                 IHaveSearch<IGetStatesDictionaryQuery>
    {
    }
}
