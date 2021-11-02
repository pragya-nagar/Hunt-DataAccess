using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class DecisionMap : IEntityTypeConfiguration<Decision>
    {
        public void Configure(EntityTypeBuilder<Decision> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasAlternateKey(c => new { c.DelinquencyId, c.EventDecisionLevelId });
        }
    }
}
