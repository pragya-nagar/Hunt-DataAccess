using System;
using Synergy.DataAccess.Entities.OpportunityEntities;

namespace Synergy.DataAccess.Entities.AuditModels.OpportunityEntities
{
    public class OpportunityAudit : OpportunityBase, IAuditModelFields
    {
        public DateTime InsertedOn { get; set; }

        public Guid InsertedBy { get; set; }

        public Guid OperationId { get; set; }
    }
}
