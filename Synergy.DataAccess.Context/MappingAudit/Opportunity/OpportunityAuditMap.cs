using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Synergy.DataAccess.Entities.AuditModels.OpportunityEntities;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class OpportunityAuditMap : AuditMap<OpportunityAudit, Guid>
    {
        public override void AdditionalMapping(EntityTypeBuilder<OpportunityAudit> builder)
        {
        }
    }
}
