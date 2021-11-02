using System;
using System.Threading;
using System.Threading.Tasks;

namespace Synergy.DataAccess.Abstractions.Interfaces
{
    public interface ISingleQuery<T, TResult>// where TResult : IModel
    {
        // TODO change id type from Guid to generic. Right now all agregates have Guid`s.
        T FindById(Guid id);

        TResult Exeсute();

        Task<TResult> ExeсuteAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
