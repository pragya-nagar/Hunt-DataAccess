using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class PropertyProfileStateMap : IEntityTypeConfiguration<PropertyProfileState>
    {
        public void Configure(EntityTypeBuilder<PropertyProfileState> builder)
        {
            builder.HasKey(x => new { x.PropertyProfileId, x.StateId });

            builder.HasOne(x => x.State)
                   .WithMany(x => x.PropertyProfileStates)
                   .HasForeignKey(x => x.StateId);

            builder.HasOne(x => x.PropertyProfile)
                   .WithMany(x => x.PropertyProfileStates)
                   .HasForeignKey(x => x.PropertyProfileId);
        }
    }
}
