using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class EventEntityAuditMap : AuditMap<EventEntityAudit, int>
    {
        public override void AdditionalMapping(EntityTypeBuilder<EventEntityAudit> builder)
        {
        }
    }
}
