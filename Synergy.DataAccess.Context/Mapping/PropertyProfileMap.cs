using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class PropertyProfileMap : IEntityTypeConfiguration<PropertyProfile>
    {
        public void Configure(EntityTypeBuilder<PropertyProfile> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
