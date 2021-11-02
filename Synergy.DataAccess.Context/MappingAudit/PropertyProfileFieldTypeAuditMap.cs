using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class PropertyProfileFieldTypeAuditMap : AuditMap<PropertyProfileFieldTypeAudit, int>
    {
        public override void AdditionalMapping(EntityTypeBuilder<PropertyProfileFieldTypeAudit> builder)
        {
        }
    }
}
