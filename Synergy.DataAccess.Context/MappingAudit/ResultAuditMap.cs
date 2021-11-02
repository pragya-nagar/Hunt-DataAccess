using System;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class ResultAuditMap : AuditMap<ResultAudit, Guid>
    {
        public override void AdditionalMapping(EntityTypeBuilder<ResultAudit> builder)
        {
        }
    }
}
