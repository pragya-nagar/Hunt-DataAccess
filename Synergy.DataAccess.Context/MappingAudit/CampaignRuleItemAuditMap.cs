using System;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class CampaignRuleItemAuditMap : AuditMap<CampaignRuleItemAudit, Guid>
    {
        public override void AdditionalMapping(EntityTypeBuilder<CampaignRuleItemAudit> builder)
        {
        }
    }
}
