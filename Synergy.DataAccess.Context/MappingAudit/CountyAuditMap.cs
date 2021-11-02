using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class CountyAuditMap : AuditMap<CountyAudit, int>
    {
        public override void AdditionalMapping(EntityTypeBuilder<CountyAudit> builder)
        {
        }
    }
}
