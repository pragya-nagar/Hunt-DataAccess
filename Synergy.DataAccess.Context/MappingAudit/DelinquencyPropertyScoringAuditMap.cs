using System;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class DelinquencyPropertyScoringAuditMap : AuditMap<DelinquencyPropertyScoringAudit, Guid>
    {
        public override void AdditionalMapping(EntityTypeBuilder<DelinquencyPropertyScoringAudit> builder)
        {
        }
    }
}
