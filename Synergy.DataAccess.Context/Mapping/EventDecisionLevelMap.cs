using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class EventDecisionLevelMap : IEntityTypeConfiguration<EventDecisionLevel>
    {
        public void Configure(EntityTypeBuilder<EventDecisionLevel> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}
