using System;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class DataCutRuleAuditMap : AuditMap<DataCutRuleAudit, Guid>
    {
        public override void AdditionalMapping(EntityTypeBuilder<DataCutRuleAudit> builder)
        {
        }
    }
}