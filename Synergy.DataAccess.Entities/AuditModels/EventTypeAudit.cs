using System;

namespace Synergy.DataAccess.Entities.AuditModels
{
    public class EventTypeAudit : EventTypeBase, IAuditModelFields
    {
        public DateTime InsertedOn { get; set; }

        public Guid InsertedBy { get; set; }

        public Guid OperationId { get; set; }
    }
}
