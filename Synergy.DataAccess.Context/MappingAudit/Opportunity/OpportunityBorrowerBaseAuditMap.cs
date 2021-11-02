using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class OpportunityBorrowerBaseAuditMap : AuditMap<OpportunityBorrowerBaseAudit, Guid>
    {
        public override void AdditionalMapping(EntityTypeBuilder<OpportunityBorrowerBaseAudit> builder)
        {
        }
    }
}
