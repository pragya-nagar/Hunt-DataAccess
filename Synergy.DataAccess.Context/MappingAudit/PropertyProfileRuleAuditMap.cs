using System;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class PropertyProfileRuleAuditMap : AuditMap<PropertyProfileRuleAudit, Guid>
    {
        public override void AdditionalMapping(EntityTypeBuilder<PropertyProfileRuleAudit> builder)
        {
        }
    }
}
