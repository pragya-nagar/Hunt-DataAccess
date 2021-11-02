using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class PropertyProfileRuleMap : IEntityTypeConfiguration<PropertyProfileRule>
    {
        public void Configure(EntityTypeBuilder<PropertyProfileRule> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
