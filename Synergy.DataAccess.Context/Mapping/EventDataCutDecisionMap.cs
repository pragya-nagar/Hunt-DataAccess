using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class EventDataCutDecisionMap : IEntityTypeConfiguration<EventDataCutDecision>
    {
        public void Configure(EntityTypeBuilder<EventDataCutDecision> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}
