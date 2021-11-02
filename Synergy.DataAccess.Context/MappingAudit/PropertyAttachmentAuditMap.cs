using System;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class PropertyAttachmentAuditMap : AuditMap<PropertyAttachmentAudit, Guid>
    {
        public override void AdditionalMapping(EntityTypeBuilder<PropertyAttachmentAudit> builder)
        {
        }
    }
}
