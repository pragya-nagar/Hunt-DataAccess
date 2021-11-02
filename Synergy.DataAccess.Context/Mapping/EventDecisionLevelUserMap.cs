using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class EventDecisionLevelUserMap : IEntityTypeConfiguration<EventDecisionLevelUser>
    {
        public void Configure(EntityTypeBuilder<EventDecisionLevelUser> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}
