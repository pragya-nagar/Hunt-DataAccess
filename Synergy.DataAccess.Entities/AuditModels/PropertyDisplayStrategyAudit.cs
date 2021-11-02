using System;

namespace Synergy.DataAccess.Entities.AuditModels
{
    public class PropertyDisplayStrategyAudit : PropertyDisplayStrategyBase, IAuditModelFields
    {
        public DateTime InsertedOn { get; set; }

        public Guid InsertedBy { get; set; }

        public Guid OperationId { get; set; }
    }
}
