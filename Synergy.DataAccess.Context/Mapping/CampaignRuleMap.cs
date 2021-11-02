using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class CampaignRuleMap : IEntityTypeConfiguration<CampaignRule>
    {
        public void Configure(EntityTypeBuilder<CampaignRule> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
