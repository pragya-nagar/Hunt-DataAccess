using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class DelinquencyPropertyScoringMap : IEntityTypeConfiguration<DelinquencyPropertyScoring>
    {
        public void Configure(EntityTypeBuilder<DelinquencyPropertyScoring> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Delinquency)
                   .WithMany(x => x.DelinquencyPropertyScorings)
                   .HasForeignKey(x => x.DelinquencyId);
        }
    }
}
