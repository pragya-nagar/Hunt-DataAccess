using System;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class PropertyProfileDelinquencyAuditMap : AuditMap<PropertyProfileDelinquencyAudit, Guid>
    {
        public override void AdditionalMapping(EntityTypeBuilder<PropertyProfileDelinquencyAudit> builder)
        {
        }
    }
}
