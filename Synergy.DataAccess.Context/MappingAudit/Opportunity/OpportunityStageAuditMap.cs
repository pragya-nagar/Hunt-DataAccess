﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class OpportunityStageAuditMap : AuditMap<OpportunityStageAudit, int>
    {
        public override void AdditionalMapping(EntityTypeBuilder<OpportunityStageAudit> builder)
        {
        }
    }
}
