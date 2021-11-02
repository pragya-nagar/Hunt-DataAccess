using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class PropertySupplementalEventDataMap : IEntityTypeConfiguration<PropertySupplementalEventData>
    {
        public void Configure(EntityTypeBuilder<PropertySupplementalEventData> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}
