using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class PropertyAttachmentTypeAuditMap : AuditMap<PropertyAttachmentTypeAudit, int>
    {
        public override void AdditionalMapping(EntityTypeBuilder<PropertyAttachmentTypeAudit> builder)
        {
        }
    }
}
