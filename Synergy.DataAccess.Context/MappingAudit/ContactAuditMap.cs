using System;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class ContactAuditMap : AuditMap<ContactAudit, Guid>
    {
        public override void AdditionalMapping(EntityTypeBuilder<ContactAudit> builder)
        {
        }
    }
}
