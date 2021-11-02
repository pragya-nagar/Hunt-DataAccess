using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Synergy.DataAccess.Entities.AuditModels.Processing;

namespace Synergy.DataAccess.Context.MappingAudit.Processing
{
    public class LoanStageAuditMap : AuditMap<LoanStageAudit, int>
    {
        public override void AdditionalMapping(EntityTypeBuilder<LoanStageAudit> builder)
        {
        }
    }
}
