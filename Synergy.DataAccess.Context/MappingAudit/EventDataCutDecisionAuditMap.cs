using System;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    internal class EventDataCutDecisionAuditMap : AuditMap<EventDataCutDecisionAudit, Guid>
    {
        public override void AdditionalMapping(EntityTypeBuilder<EventDataCutDecisionAudit> builder)
        {
        }
    }
}
