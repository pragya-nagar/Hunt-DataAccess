using System;

namespace Synergy.DataAccess.Entities.AuditModels
{
    public class EventAttachmentAudit : EventAttachmentBase, IAuditModelFields
    {
        public DateTime InsertedOn { get; set; }

        public Guid InsertedBy { get; set; }

        public Guid OperationId { get; set; }
    }
}
