using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Synergy.DataAccess.Entities.AuditModels.Processing;

namespace Synergy.DataAccess.Context.MappingAudit.Processing
{
    public class LoanPropertyTypeAuditMap : AuditMap<LoanPropertyTypeAudit, int>
    {
        public override void AdditionalMapping(EntityTypeBuilder<LoanPropertyTypeAudit> builder)
        {
        }
    }
}
