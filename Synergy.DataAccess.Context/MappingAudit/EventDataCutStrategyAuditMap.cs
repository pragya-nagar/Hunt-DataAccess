using System;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    internal class EventDataCutStrategyAuditMap : AuditMap<EventDataCutStrategyAudit, Guid>
    {
        public override void AdditionalMapping(EntityTypeBuilder<EventDataCutStrategyAudit> builder)
        {
        }
    }
}
