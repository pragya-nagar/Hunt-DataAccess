using System;

namespace Synergy.DataAccess.Entities.AuditModels
{
    public class CampaignRuleFieldAudit : CampaignRuleFieldBase, IAuditModelFields
    {
        public DateTime InsertedOn { get; set; }

        public Guid InsertedBy { get; set; }

        public Guid OperationId { get; set; }
    }
}
