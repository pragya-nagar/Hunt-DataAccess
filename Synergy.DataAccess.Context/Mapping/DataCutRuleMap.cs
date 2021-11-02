using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class DataCutRuleMap : IEntityTypeConfiguration<DataCutRule>
    {
        public void Configure(EntityTypeBuilder<DataCutRule> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
