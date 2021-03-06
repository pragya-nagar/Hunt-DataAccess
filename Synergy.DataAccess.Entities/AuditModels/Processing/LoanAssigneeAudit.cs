using System;
using Synergy.DataAccess.Entities.Processing;

namespace Synergy.DataAccess.Entities.AuditModels.Processing
{
    public class LoanAssigneeAudit : LoanAssigneeBase, IAuditModelFields
    {
        public DateTime InsertedOn { get; set; }

        public Guid InsertedBy { get; set; }

        public Guid OperationId { get; set; }
    }
}