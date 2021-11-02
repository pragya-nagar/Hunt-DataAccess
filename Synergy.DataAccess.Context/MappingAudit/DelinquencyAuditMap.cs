using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class DelinquencyAuditMap : AuditMap<DelinquencyAudit, Guid>
    {
        public override void AdditionalMapping(EntityTypeBuilder<DelinquencyAudit> builder)
        {
            builder.Property(b => b.IsLoan).HasDefaultValue(false);
        }
    }
}