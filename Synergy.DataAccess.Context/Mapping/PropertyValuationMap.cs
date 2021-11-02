using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class PropertyValuationMap : IEntityTypeConfiguration<PropertyValuation>
    {
        public void Configure(EntityTypeBuilder<PropertyValuation> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}
