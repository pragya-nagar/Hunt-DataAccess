using System;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class CampaignRuleCampaignAuditMap : AuditMap<CampaignRuleCampaignAudit, Guid>
    {
        public override void AdditionalMapping(EntityTypeBuilder<CampaignRuleCampaignAudit> builder)
        {
        }
    }
}
