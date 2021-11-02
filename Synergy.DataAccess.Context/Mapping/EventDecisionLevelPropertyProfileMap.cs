using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class EventDecisionLevelPropertyProfileMap : IEntityTypeConfiguration<EventDecisionLevelPropertyProfile>
    {
        public void Configure(EntityTypeBuilder<EventDecisionLevelPropertyProfile> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasIndex(x => new { x.EventDecisionLevelId, x.PropertyProfileId, x.Order }).IsUnique();
        }
    }
}
