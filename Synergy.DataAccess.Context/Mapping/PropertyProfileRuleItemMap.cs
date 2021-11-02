using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class PropertyProfileRuleItemMap : IEntityTypeConfiguration<PropertyProfileRuleItem>
    {
        public void Configure(EntityTypeBuilder<PropertyProfileRuleItem> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
