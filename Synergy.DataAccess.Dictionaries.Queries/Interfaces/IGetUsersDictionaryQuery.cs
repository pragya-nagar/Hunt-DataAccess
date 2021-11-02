using System;
using System.Collections.Generic;

using Synergy.DataAccess.Abstractions.Interfaces;
using Synergy.DataAccess.Abstractions.Models;

namespace Synergy.DataAccess.Dictionaries.Queries.Interfaces
{
    public interface IGetUsersDictionaryQuery : IQuery<IGetUsersDictionaryQuery, IEnumerable<FastEntityModel<Guid>>>,
                                               IHavePagination<IGetUsersDictionaryQuery>,
                                               IHaveSearch<IGetUsersDictionaryQuery>
    {
    }
}
