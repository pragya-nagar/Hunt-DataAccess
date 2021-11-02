using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class CampaignRuleItemMap : IEntityTypeConfiguration<CampaignRuleItem>
    {
        public void Configure(EntityTypeBuilder<CampaignRuleItem> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
