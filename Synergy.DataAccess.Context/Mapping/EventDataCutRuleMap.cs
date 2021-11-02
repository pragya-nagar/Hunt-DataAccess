using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class EventDataCutRuleMap : IEntityTypeConfiguration<EventDataCutRule>
    {
        public void Configure(EntityTypeBuilder<EventDataCutRule> builder)
        {
            builder.HasKey(er => new { er.EventDataCutStrategyId, er.DataCutRuleId });

            builder.HasOne(e => e.EventDataCutStrategy)
                .WithMany(r => r.EventDataCutRules)
                .HasForeignKey(er => er.EventDataCutStrategyId);
        }
    }
}
