using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class InternalLandUseCodeAuditMap : AuditMap<InternalLandUseCodeAudit, int>
    {
        public override void AdditionalMapping(EntityTypeBuilder<InternalLandUseCodeAudit> builder)
        {
        }
    }
}
