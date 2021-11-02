using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class DataCutRuleFieldAuditMap : AuditMap<DataCutRuleFieldAudit, int>
    {
        public override void AdditionalMapping(EntityTypeBuilder<DataCutRuleFieldAudit> builder)
        {
        }
    }
}
