using System;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class LeadAuditMap : AuditMap<LeadAudit, Guid>
    {
        public override void AdditionalMapping(EntityTypeBuilder<LeadAudit> builder)
        {
        }
    }
}
