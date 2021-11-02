namespace Synergy.DataAccess.Abstractions.Interfaces
{
    public interface IHavePagination<T>
    {
        int? TotalCount { get; }

        T Take(int take);

        T Skip(int skip);
    }
}
