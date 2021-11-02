using System;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class OpportunityPropertyAuditMap : AuditMap<OpportunityPropertyAudit, Guid>
    {
        public override void AdditionalMapping(EntityTypeBuilder<OpportunityPropertyAudit> builder)
        {
        }
    }
}
