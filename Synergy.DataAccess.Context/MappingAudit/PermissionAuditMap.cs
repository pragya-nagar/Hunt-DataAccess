using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class PermissionAuditMap : AuditMap<PermissionAudit, int>
    {
        public override void AdditionalMapping(EntityTypeBuilder<PermissionAudit> builder)
        {
        }
    }
}
