using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class CampaignLeadMap : IEntityTypeConfiguration<CampaignLead>
    {
        public void Configure(EntityTypeBuilder<CampaignLead> builder)
        {
            builder.HasKey(cl => new { cl.CampaignId, cl.LeadId });
            builder.HasOne(c => c.Campaign)
                .WithMany(cl => cl.CampaignLeads)
                .HasForeignKey(c => c.CampaignId);
            builder.HasOne(l => l.Lead)
                .WithMany(cl => cl.CampaignLeads)
                .HasForeignKey(l => l.LeadId);
        }
    }
}
