using System;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class UserPermissionAuditMap : AuditMap<UserPermissionAudit, Guid>
    {
        public override void AdditionalMapping(EntityTypeBuilder<UserPermissionAudit> builder)
        {
        }
    }
}
