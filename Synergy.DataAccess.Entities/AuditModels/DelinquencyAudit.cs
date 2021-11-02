using System;

namespace Synergy.DataAccess.Entities.AuditModels
{
    public class DelinquencyAudit : DelinquencyBase, IAuditModelFields
    {
        public DateTime InsertedOn { get; set; }

        public Guid InsertedBy { get; set; }

        public Guid OperationId { get; set; }
    }
}
