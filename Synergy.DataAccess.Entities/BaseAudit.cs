using System;

namespace Synergy.DataAccess.Entities
{
    public abstract class BaseAudit<T>
    {
        public T Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public Guid CreatedById { get; set; }

        public DateTime ModifiedOn { get; set; }

        public Guid ModifiedById { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
