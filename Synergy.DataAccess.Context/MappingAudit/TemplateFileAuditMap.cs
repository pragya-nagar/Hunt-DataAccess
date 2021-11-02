using System;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class TemplateFileAuditMap : AuditMap<TemplateFileAudit, Guid>
    {
        public override void AdditionalMapping(EntityTypeBuilder<TemplateFileAudit> builder)
        {
        }
    }
}