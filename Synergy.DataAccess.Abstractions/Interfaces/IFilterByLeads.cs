using System;
using System.Collections.Generic;

namespace Synergy.DataAccess.Abstractions.Interfaces
{
    public interface IFilterByLeads<T>
    {
        T FilterByLeads(IEnumerable<Guid> ids);
    }
}
