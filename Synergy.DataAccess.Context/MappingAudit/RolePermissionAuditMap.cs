using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    internal class RolePermissionAuditMap : AuditMap<RolePermissionAudit, int>
    {
        public override void AdditionalMapping(EntityTypeBuilder<RolePermissionAudit> builder)
        {
        }
    }
}
