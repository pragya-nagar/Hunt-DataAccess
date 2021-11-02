using System;

namespace Synergy.DataAccess.Entities
{
    public abstract class NotificationMessageBase : BaseAudit<Guid>
    {
        public Guid EntityId { get; set; }

        public string TypeIdentifier { get; set; }

        public string Metadata { get; set; }

        public Guid UserId { get; set; }
    }

    public class NotificationMessage : NotificationMessageBase, IAuditEntity<Guid>, IEntity
    {
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
    }
}
