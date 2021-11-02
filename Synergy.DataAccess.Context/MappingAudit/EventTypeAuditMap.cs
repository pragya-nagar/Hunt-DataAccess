using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class EventTypeAuditMap : AuditMap<EventTypeAudit, int>
    {
        public override void AdditionalMapping(EntityTypeBuilder<EventTypeAudit> builder)
        {
        }
    }
}
