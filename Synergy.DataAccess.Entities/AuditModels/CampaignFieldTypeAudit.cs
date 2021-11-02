using System;

namespace Synergy.DataAccess.Entities.AuditModels
{
    public class CampaignFieldTypeAudit : CampaignFieldTypeBase, IAuditModelFields
    {
        public DateTime InsertedOn { get; set; }

        public Guid InsertedBy { get; set; }

        public Guid OperationId { get; set; }
    }
}
