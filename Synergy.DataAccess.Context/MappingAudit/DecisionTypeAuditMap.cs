using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class DecisionTypeAuditMap : AuditMap<DecisionTypeAudit, int>
    {
        public override void AdditionalMapping(EntityTypeBuilder<DecisionTypeAudit> builder)
        {
        }
    }
}
