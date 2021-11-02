using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class TemplateTypeAuditMap : AuditMap<TemplateTypeAudit, int>
    {
        public override void AdditionalMapping(EntityTypeBuilder<TemplateTypeAudit> builder)
        {
        }
    }
}