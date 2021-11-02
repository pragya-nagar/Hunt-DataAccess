using System;

namespace Synergy.DataAccess.Entities
{
    public interface IAuditEntity
    {
        DateTime CreatedOn { get; set; }

        Guid CreatedById { get; set; }

        User CreatedBy { get; set; }

        DateTime ModifiedOn { get; set; }

        Guid ModifiedById { get; set; }

        User ModifiedBy { get; set; }

        DateTime? DeletedOn { get; set; }
    }

    public interface IAuditEntity<T> : IAuditEntity
    {
        T Id { get; set; }
    }
}
