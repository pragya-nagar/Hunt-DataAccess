using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class ModuleAuditMap : AuditMap<ModuleAudit, int>
    {
        public override void AdditionalMapping(EntityTypeBuilder<ModuleAudit> builder)
        {
        }
    }
}