using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class PropertyProfileDelinquencyMap : IEntityTypeConfiguration<PropertyProfileDelinquency>
    {
        public void Configure(EntityTypeBuilder<PropertyProfileDelinquency> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasIndex(e => new { e.DelinquencyId, e.PropertyProfileId }).IsUnique();
        }
    }
}
