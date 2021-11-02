using System;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class PropertyProfileRulePropertyProfileAuditMap : AuditMap<PropertyProfileRulePropertyProfileAudit, Guid>
    {
        public override void AdditionalMapping(EntityTypeBuilder<PropertyProfileRulePropertyProfileAudit> builder)
        {
        }
    }
}
