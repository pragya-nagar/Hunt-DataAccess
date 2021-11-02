using System;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class EventAttachmentAuditMap : AuditMap<EventAttachmentAudit, Guid>
    {
        public override void AdditionalMapping(EntityTypeBuilder<EventAttachmentAudit> builder)
        {
        }
    }
}