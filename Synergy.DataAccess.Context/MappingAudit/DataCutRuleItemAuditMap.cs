using System;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class DataCutRuleItemAuditMap : AuditMap<DataCutRuleItemAudit, Guid>
    {
        public override void AdditionalMapping(EntityTypeBuilder<DataCutRuleItemAudit> builder)
        {
        }
    }
}