using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class StateTaxeAuditMap : AuditMap<StateTaxeAudit, int>
    {
        public override void AdditionalMapping(EntityTypeBuilder<StateTaxeAudit> builder)
        {
        }
    }
}
