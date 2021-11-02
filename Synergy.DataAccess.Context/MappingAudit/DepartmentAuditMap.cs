using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class DepartmentAuditMap : AuditMap<DepartmentAudit, int>
    {
        public override void AdditionalMapping(EntityTypeBuilder<DepartmentAudit> builder)
        {
        }
    }
}