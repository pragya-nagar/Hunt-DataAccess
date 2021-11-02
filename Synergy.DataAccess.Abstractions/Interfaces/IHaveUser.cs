using System;

namespace Synergy.DataAccess.Abstractions.Interfaces
{
    public interface IHaveUser<T>
    {
        T FindByUserId(Guid userId);
    }
}
