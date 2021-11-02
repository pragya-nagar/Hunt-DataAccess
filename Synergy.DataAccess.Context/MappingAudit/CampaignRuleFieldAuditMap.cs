using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class CampaignRuleFieldAuditMap : AuditMap<CampaignRuleFieldAudit, int>
    {
        public override void AdditionalMapping(EntityTypeBuilder<CampaignRuleFieldAudit> builder)
        {
        }
    }
}
