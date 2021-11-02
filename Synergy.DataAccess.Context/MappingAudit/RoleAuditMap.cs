using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class RoleAuditMap : AuditMap<RoleAudit, Guid>
    {
        public override void AdditionalMapping(EntityTypeBuilder<RoleAudit> builder)
        {
            builder.Property(x => x.IsActive).HasDefaultValue(true);
        }
    }
}
