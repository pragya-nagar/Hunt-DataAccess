using System;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class CampaignAuditMap : AuditMap<CampaignAudit, Guid>
    {
        public override void AdditionalMapping(EntityTypeBuilder<CampaignAudit> builder)
        {
        }
    }
}
