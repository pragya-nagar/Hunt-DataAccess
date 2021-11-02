using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class PropertyNotesAuditMap : AuditMap<PropertyNotesAudit, Guid>
    {
        public override void AdditionalMapping(EntityTypeBuilder<PropertyNotesAudit> builder)
        {
        }
    }
}
