using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class AuctionTypeAuditMap : AuditMap<AuctionTypeAudit, int>
    {
        public override void AdditionalMapping(EntityTypeBuilder<AuctionTypeAudit> builder)
        {
        }
    }
}
