using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class DelinquencyPropertyDisplayStrategyMap : IEntityTypeConfiguration<DelinquencyPropertyDisplayStrategy>
    {
        public void Configure(EntityTypeBuilder<DelinquencyPropertyDisplayStrategy> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Delinquency)
                .WithMany(x => x.DelinquencyPropertyDisplayStrategy)
                .HasForeignKey(x => x.DelinquencyId);

            builder.HasOne(x => x.PropertyDisplayStrategy)
                .WithMany(x => x.DelinquencyPropertyDisplayStrategy)
                .HasForeignKey(x => x.PropertyDisplayStrategyId);
        }
    }
}
