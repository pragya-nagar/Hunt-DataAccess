using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class DataCutFieldTypeAuditMap : AuditMap<DataCutFieldTypeAudit, int>
    {
        public override void AdditionalMapping(EntityTypeBuilder<DataCutFieldTypeAudit> builder)
        {
        }
    }
}
