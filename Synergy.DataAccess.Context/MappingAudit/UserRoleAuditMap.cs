using System;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class UserRoleAuditMap : AuditMap<UserRoleAudit, Guid>
    {
        public override void AdditionalMapping(EntityTypeBuilder<UserRoleAudit> builder)
        {
        }
    }
}
