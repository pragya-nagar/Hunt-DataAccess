using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class CampaignLogicTypeAuditMap : AuditMap<CampaignLogicTypeAudit, int>
    {
        public override void AdditionalMapping(EntityTypeBuilder<CampaignLogicTypeAudit> builder)
        {
        }
    }
}
