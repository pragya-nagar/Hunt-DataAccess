using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class DataCutLogicTypeAuditMap : AuditMap<DataCutLogicTypeAudit, int>
    {
        public override void AdditionalMapping(EntityTypeBuilder<DataCutLogicTypeAudit> builder)
        {
        }
    }
}
