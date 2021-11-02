using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class CampaignTypeAuditMap : AuditMap<CampaignTypeAudit, int>
    {
        public override void AdditionalMapping(EntityTypeBuilder<CampaignTypeAudit> builder)
        {
        }
    }
}
