using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class GeneralLandUseCodeAuditMap : AuditMap<GeneralLandUseCodeAudit, int>
    {
        public override void AdditionalMapping(EntityTypeBuilder<GeneralLandUseCodeAudit> builder)
        {
        }
    }
}
