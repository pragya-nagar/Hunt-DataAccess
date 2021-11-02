using System;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class PropertyProfileRuleItemAuditMap : AuditMap<PropertyProfileRuleItemAudit, Guid>
    {
        public override void AdditionalMapping(EntityTypeBuilder<PropertyProfileRuleItemAudit> builder)
        {
        }
    }
}
