using System;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class PropertyProfileRuleItemValueAuditMap : AuditMap<PropertyProfileRuleItemValueAudit, Guid>
    {
        public override void AdditionalMapping(EntityTypeBuilder<PropertyProfileRuleItemValueAudit> builder)
        {
        }
    }
}
