namespace Synergy.DataAccess.Abstractions.Interfaces
{
    public interface IHaveSearch<T>
    {
        T Search(string search);
    }
}
