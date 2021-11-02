using System;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class CollectingEntityAuditMap : AuditMap<CollectingEntityAudit, Guid>
    {
        public override void AdditionalMapping(EntityTypeBuilder<CollectingEntityAudit> builder)
        {
        }
    }
}
