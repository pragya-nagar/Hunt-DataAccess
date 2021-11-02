using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class DataCutRuleItemMap : IEntityTypeConfiguration<DataCutRuleItem>
    {
        public void Configure(EntityTypeBuilder<DataCutRuleItem> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
