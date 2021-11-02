using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class PropertyDisplayStrategyAuditMap : AuditMap<PropertyDisplayStrategyAudit, int>
    {
        public override void AdditionalMapping(EntityTypeBuilder<PropertyDisplayStrategyAudit> builder)
        {
        }
    }
}
