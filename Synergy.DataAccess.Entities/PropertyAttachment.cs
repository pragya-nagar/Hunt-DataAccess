using System;

namespace Synergy.DataAccess.Entities
{
    public abstract class PropertyAttachmentBase : BaseAudit<Guid>
    {
        public Guid PropertyId { get; set; }

        public string FileName { get; set; }

        public string ContentType { get; set; }

        public string Path { get; set; }

        public DateTime FileCreatedOn { get; set; }

        public int PropertyAttachmentTypeId { get; set; }
    }

    public class PropertyAttachment : PropertyAttachmentBase, IAuditEntity<Guid>, IEntity
    {
        public Property Property { get; set; }

        public PropertyAttachmentType PropertyAttachmentType { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
