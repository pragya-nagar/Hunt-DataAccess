using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Synergy.DataAccess.Entities.AuditModels.Processing;

namespace Synergy.DataAccess.Context.MappingAudit.Processing
{
    public class LoanPropertyAuditMap : AuditMap<LoanPropertyAudit, Guid>
    {
        public override void AdditionalMapping(EntityTypeBuilder<LoanPropertyAudit> builder)
        {
        }
    }
}
