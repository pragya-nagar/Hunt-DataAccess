using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Synergy.DataAccess.Abstractions.Interfaces
{
    public interface IQuery<T, TResult>
        where TResult : IEnumerable<IModel>
    {
        // TODO change id type from Guid to generic. Right now all agregates have Guid`s.
        // TODO move this to separete interface
        T FindById(Guid id);

        TResult Exeсute();

        Task<TResult> ExeсuteAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
