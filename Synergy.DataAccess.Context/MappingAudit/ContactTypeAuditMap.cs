using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class ContactTypeAuditMap : AuditMap<ContactTypeAudit, int>
    {
        public override void AdditionalMapping(EntityTypeBuilder<ContactTypeAudit> builder)
        {
        }
    }
}
