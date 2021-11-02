using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class PropertyMap : IEntityTypeConfiguration<Property>
    {
        public void Configure(EntityTypeBuilder<Property> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasIndex(b => b.PropertyBK);

            // Added PostgreSQL case insensitive index in AddCaseSensitiveIndexPropertyCountyJurisdiction Migration
        }
    }
}
