using System;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class EventAuditMap : AuditMap<EventAudit, Guid>
    {
        public override void AdditionalMapping(EntityTypeBuilder<EventAudit> builder)
        {
        }
    }
}
