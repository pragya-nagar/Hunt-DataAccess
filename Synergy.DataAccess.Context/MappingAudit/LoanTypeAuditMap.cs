﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class LoanTypeAuditMap : AuditMap<LoanTypeAudit, int>
    {
        public override void AdditionalMapping(EntityTypeBuilder<LoanTypeAudit> builder)
        {
        }
    }
}
