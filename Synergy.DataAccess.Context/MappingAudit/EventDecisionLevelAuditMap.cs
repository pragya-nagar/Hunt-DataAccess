using System;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class EventDecisionLevelAuditMap : AuditMap<EventDecisionLevelAudit, Guid>
    {
        public override void AdditionalMapping(EntityTypeBuilder<EventDecisionLevelAudit> builder)
        {
        }
    }
}