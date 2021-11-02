namespace Synergy.DataAccess.Abstractions.Interfaces
{
    public interface IHaveSorting<T, TEnum>
        where TEnum : struct
    {
        T OrderBy(TEnum sortField);

        T OrderByDescending(TEnum sortField);
    }
}
