using System;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class EventDataCutRuleAuditMap : AuditMap<EventDataCutRuleAudit, Guid>
    {
        public override void AdditionalMapping(EntityTypeBuilder<EventDataCutRuleAudit> builder)
        {
        }
    }
}
