using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Synergy.DataAccess.Entities.AuditModels.Processing;

namespace Synergy.DataAccess.Context.MappingAudit.Processing
{
    public class BorrowerAuditMap : AuditMap<BorrowerAudit, Guid>
    {
        public override void AdditionalMapping(EntityTypeBuilder<BorrowerAudit> builder)
        {
        }
    }
}
