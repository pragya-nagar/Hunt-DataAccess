using System;

namespace Synergy.DataAccess.Entities.AuditModels
{
    public class CountyAudit : CountyBase, IAuditModelFields
    {
        public DateTime InsertedOn { get; set; }

        public Guid InsertedBy { get; set; }

        public Guid OperationId { get; set; }
    }
}
