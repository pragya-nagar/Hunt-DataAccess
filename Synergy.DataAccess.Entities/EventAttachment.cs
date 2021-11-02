using System;

namespace Synergy.DataAccess.Entities
{
    public abstract class EventAttachmentBase : BaseAudit<Guid>
    {
        public Guid EventId { get; set; }

        public string FileName { get; set; }

        public string ContentType { get; set; }

        public string Path { get; set; }
    }

    public class EventAttachment : EventAttachmentBase, IAuditEntity<Guid>, IEntity
    {
        public Event Event { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
