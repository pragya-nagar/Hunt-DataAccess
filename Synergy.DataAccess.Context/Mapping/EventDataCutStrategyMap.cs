using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    internal class EventDataCutStrategyMap : IEntityTypeConfiguration<EventDataCutStrategy>
    {
        public void Configure(EntityTypeBuilder<EventDataCutStrategy> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}
