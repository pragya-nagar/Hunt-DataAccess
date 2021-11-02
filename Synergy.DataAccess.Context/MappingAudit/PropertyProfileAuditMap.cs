using System;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class PropertyProfileAuditMap : AuditMap<PropertyProfileAudit, Guid>
    {
        public override void AdditionalMapping(EntityTypeBuilder<PropertyProfileAudit> builder)
        {
        }
    }
}
