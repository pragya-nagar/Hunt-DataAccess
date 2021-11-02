using System;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class DecisionAuditMap : AuditMap<DecisionAudit, Guid>
    {
        public override void AdditionalMapping(EntityTypeBuilder<DecisionAudit> builder)
        {
        }
    }
}