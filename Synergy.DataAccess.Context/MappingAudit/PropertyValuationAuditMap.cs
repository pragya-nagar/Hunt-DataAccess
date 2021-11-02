using System;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class PropertyValuationAuditMap : AuditMap<PropertyValuationAudit, Guid>
    {
        public override void AdditionalMapping(EntityTypeBuilder<PropertyValuationAudit> builder)
        {
        }
    }
}
