using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class PropertyProfileRulePropertyProfileMap : IEntityTypeConfiguration<PropertyProfileRulePropertyProfile>
    {
        public void Configure(EntityTypeBuilder<PropertyProfileRulePropertyProfile> builder)
        {
            builder.HasKey(x => new { x.PropertyProfileRuleId, x.PropertyProfileId });

            builder.HasOne(x => x.PropertyProfile)
                   .WithMany(x => x.PropertyProfileRulePropertyProfiles)
                   .HasForeignKey(x => x.PropertyProfileId);

            builder.HasOne(x => x.PropertyProfileRule)
                   .WithMany(x => x.PropertyProfileRulePropertyProfiles)
                   .HasForeignKey(x => x.PropertyProfileRuleId);
        }
    }
}
