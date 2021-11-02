using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class PropertyProfileLogicTypeAuditMap : AuditMap<PropertyProfileLogicTypeAudit, int>
    {
        public override void AdditionalMapping(EntityTypeBuilder<PropertyProfileLogicTypeAudit> builder)
        {
        }
    }
}
