using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class StateAuditMap : AuditMap<StateAudit, int>
    {
        public override void AdditionalMapping(EntityTypeBuilder<StateAudit> builder)
        {
        }
    }
}
