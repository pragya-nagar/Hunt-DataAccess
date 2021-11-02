using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class SaleDateStatusAuditMap : AuditMap<SaleDateStatusAudit, int>
    {
        public override void AdditionalMapping(EntityTypeBuilder<SaleDateStatusAudit> builder)
        {
        }
    }
}
