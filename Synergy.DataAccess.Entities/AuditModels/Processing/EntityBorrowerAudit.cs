using System;
using Synergy.DataAccess.Entities.Processing;

namespace Synergy.DataAccess.Entities.AuditModels.Processing
{
    public class EntityBorrowerAudit : EntityBorrowerBase, IAuditModelFields
    {
        public DateTime InsertedOn { get; set; }

        public Guid InsertedBy { get; set; }

        public Guid OperationId { get; set; }
    }
}
