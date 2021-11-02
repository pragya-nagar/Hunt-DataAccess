using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class UserAuditMap : AuditMap<UserAudit, Guid>
    {
        public override void AdditionalMapping(EntityTypeBuilder<UserAudit> builder)
        {
            builder.Property(x => x.IsActive).HasDefaultValue(true);
        }
    }
}
