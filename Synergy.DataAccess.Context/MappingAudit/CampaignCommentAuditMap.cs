using System;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class CampaignCommentAuditMap : AuditMap<CampaignCommentAudit, Guid>
    {
        public override void AdditionalMapping(EntityTypeBuilder<CampaignCommentAudit> builder)
        {
        }
    }
}
