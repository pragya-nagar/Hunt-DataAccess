namespace Synergy.DataAccess.Abstractions.Interfaces
{
    public interface IIncludeAudit<T>
    {
        T IncludeAudit();
    }
}
