using System;
using System.Threading;
using System.Threading.Tasks;

namespace Synergy.DataAccess.Abstractions.Commands.Interfaces
{
    public abstract class Command<TEntity> : ICommand<TEntity>
    {
        public void Dispatch(TEntity entity, Guid userId)
        {
            this.DispatchAsync(entity, userId).GetAwaiter().GetResult();
        }

        public abstract Task<int> DispatchAsync(TEntity entity, Guid userId, CancellationToken cancellationToken = default(CancellationToken));
    }
}