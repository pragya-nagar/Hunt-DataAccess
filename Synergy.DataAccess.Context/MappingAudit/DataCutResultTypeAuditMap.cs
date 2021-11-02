using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class DataCutResultTypeAuditMap : AuditMap<DataCutResultTypeAudit, int>
    {
        public override void AdditionalMapping(EntityTypeBuilder<DataCutResultTypeAudit> builder)
        {
        }
    }
}
