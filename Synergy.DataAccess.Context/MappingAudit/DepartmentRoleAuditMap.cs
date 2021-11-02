using System;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class DepartmentRoleAuditMap : AuditMap<DepartmentRoleAudit, Guid>
    {
        public override void AdditionalMapping(EntityTypeBuilder<DepartmentRoleAudit> builder)
        {
        }
    }
}
