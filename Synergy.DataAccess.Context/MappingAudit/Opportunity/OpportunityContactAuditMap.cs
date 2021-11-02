using System;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class OpportunityContactAuditMap : AuditMap<OpportunityContactAudit, Guid>
    {
        public override void AdditionalMapping(EntityTypeBuilder<OpportunityContactAudit> builder)
        {
        }
    }
}
