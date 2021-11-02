using System;
using System.Collections.Generic;
using System.Text;

namespace Synergy.DataAccess.Entities.AuditModels.Processing
{
    public class LoanStageAudit : LoanStageBase, IAuditModelFields
    {
        public DateTime InsertedOn { get; set; }

        public Guid InsertedBy { get; set; }

        public Guid OperationId { get; set; }
    }
}
