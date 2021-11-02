using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class CollectingEntityTypeAuditMap : AuditMap<CollectingEntityTypeAudit, int>
    {
        public override void AdditionalMapping(EntityTypeBuilder<CollectingEntityTypeAudit> builder)
        {
        }
    }
}
