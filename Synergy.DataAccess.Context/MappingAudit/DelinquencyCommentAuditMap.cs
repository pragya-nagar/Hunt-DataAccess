using System;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class DelinquencyCommentAuditMap : AuditMap<DelinquencyCommentAudit, Guid>
    {
        public override void AdditionalMapping(EntityTypeBuilder<DelinquencyCommentAudit> builder)
        {
        }
    }
}
