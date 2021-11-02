using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class CampaignFieldTypeAuditMap : AuditMap<CampaignFieldTypeAudit, int>
    {
        public override void AdditionalMapping(EntityTypeBuilder<CampaignFieldTypeAudit> builder)
        {
        }
    }
}
