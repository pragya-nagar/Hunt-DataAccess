using System;

namespace Synergy.DataAccess.Entities.AuditModels
{
    public class EventDecisionLevelPropertyProfileAudit : EventDecisionLevelPropertyProfileBase, IAuditModelFields
    {
        public DateTime InsertedOn { get; set; }

        public Guid InsertedBy { get; set; }

        public Guid OperationId { get; set; }
    }
}
