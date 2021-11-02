using System.Threading;
using System.Threading.Tasks;

namespace Synergy.DataAccess.Abstractions.Commands.Interfaces
{
    public interface IQuery<TResult>
    {
        TResult Execute();

        Task<TResult> ExecuteAsync(CancellationToken cancellationToken = default(CancellationToken));
    }

    public interface IQuery<in TArgs, TResult>
    {
        TResult Execute(TArgs args);

        Task<TResult> ExecuteAsync(TArgs args, CancellationToken cancellationToken = default(CancellationToken));
    }
}