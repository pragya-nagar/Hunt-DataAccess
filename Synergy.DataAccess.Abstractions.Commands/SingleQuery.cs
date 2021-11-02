using System.Threading;
using System.Threading.Tasks;

namespace Synergy.DataAccess.Abstractions.Commands.Interfaces
{
#pragma warning disable SA1402 // File may only contain a single class
    public abstract class SingleQuery<TArgs, TResult> : IQuery<TArgs, TResult>
    {
        public TResult Execute(TArgs args)
        {
            return this.ExecuteAsync(args).GetAwaiter().GetResult();
        }

        public abstract Task<TResult> ExecuteAsync(TArgs args, CancellationToken cancellationToken = default(CancellationToken));
    }

    public abstract class SingleQuery<TResult> : IQuery<TResult>
    {
        public TResult Execute()
        {
            return this.ExecuteAsync().GetAwaiter().GetResult();
        }

        public abstract Task<TResult> ExecuteAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
#pragma warning restore SA1402 // File may only contain a single class
}