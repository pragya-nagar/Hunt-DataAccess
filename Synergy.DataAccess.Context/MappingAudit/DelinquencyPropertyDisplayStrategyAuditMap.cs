using System;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class DelinquencyPropertyDisplayStrategyAuditMap : AuditMap<DelinquencyPropertyDisplayStrategyAudit, Guid>
    {
        public override void AdditionalMapping(EntityTypeBuilder<DelinquencyPropertyDisplayStrategyAudit> builder)
        {
        }
    }
}
