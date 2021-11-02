using System;
using System.Threading;
using System.Threading.Tasks;

namespace Synergy.DataAccess.Abstractions.Commands.Interfaces
{
    public interface ICommand<in T>
    {
        void Dispatch(T entity, Guid userId);

        Task<int> DispatchAsync(T entity, Guid userId, CancellationToken cancellationToken = default(CancellationToken));
    }
}
