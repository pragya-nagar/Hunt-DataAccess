using System;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class EventDecisionLevelUserAuditMap : AuditMap<EventDecisionLevelUserAudit, Guid>
    {
        public override void AdditionalMapping(EntityTypeBuilder<EventDecisionLevelUserAudit> builder)
        {
        }
    }
}
