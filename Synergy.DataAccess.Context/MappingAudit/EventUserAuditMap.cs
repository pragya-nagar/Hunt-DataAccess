using System;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class EventUserAuditMap : AuditMap<EventUserAudit, Guid>
    {
        public override void AdditionalMapping(EntityTypeBuilder<EventUserAudit> builder)
        {
        }
    }
}
