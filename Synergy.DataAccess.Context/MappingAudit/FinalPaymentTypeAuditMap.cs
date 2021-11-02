using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class FinalPaymentTypeAuditMap : AuditMap<FinalPaymentTypeAudit, int>
    {
        public override void AdditionalMapping(EntityTypeBuilder<FinalPaymentTypeAudit> builder)
        {
        }
    }
}
