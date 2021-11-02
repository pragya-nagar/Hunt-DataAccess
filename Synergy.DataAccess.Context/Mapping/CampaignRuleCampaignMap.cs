using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    internal class CampaignRuleCampaignMap : IEntityTypeConfiguration<CampaignRuleCampaign>
    {
        public void Configure(EntityTypeBuilder<CampaignRuleCampaign> builder)
        {
            builder.HasKey(cr => new { cr.CampaignId, cr.CampaignRuleId });

            builder.HasOne(c => c.Campaign)
                .WithMany(r => r.CampaignRuleCampaign)
                .HasForeignKey(cr => cr.CampaignId);
        }
    }
}