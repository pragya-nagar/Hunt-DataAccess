using System;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class CampaignRuleAuditMap : AuditMap<CampaignRuleAudit, Guid>
    {
        public override void AdditionalMapping(EntityTypeBuilder<CampaignRuleAudit> builder)
        {
        }
    }
}
