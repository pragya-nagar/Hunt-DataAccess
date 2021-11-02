using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Synergy.DataAccess.Abstractions.Commands.Interfaces
{
#pragma warning disable SA1402 // File may only contain a single class
    public abstract class CollectionQuery<TResult> : IQuery<IQueryable<TResult>>
    {
        public IQueryable<TResult> Execute()
        {
            return this.ExecuteAsync().GetAwaiter().GetResult();
        }

        public abstract Task<IQueryable<TResult>> ExecuteAsync(CancellationToken cancellationToken = default(CancellationToken));
    }

    public abstract class CollectionQuery<TArgs, TResult> : IQuery<TArgs, IEnumerable<TResult>>
    {
        public IEnumerable<TResult> Execute(TArgs args)
        {
            return this.ExecuteAsync(args).GetAwaiter().GetResult();
        }

        public abstract Task<IEnumerable<TResult>> ExecuteAsync(TArgs args, CancellationToken cancellationToken = default(CancellationToken));
    }
#pragma warning restore SA1402 // File may only contain a single class
}