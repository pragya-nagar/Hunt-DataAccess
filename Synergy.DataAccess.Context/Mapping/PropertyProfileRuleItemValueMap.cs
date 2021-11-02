using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class PropertyProfileRuleItemValueMap : IEntityTypeConfiguration<PropertyProfileRuleItemValue>
    {
        public void Configure(EntityTypeBuilder<PropertyProfileRuleItemValue> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
