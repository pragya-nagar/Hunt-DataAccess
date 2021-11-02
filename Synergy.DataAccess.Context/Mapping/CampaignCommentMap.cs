using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class CampaignCommentMap : IEntityTypeConfiguration<CampaignComment>
    {
        public void Configure(EntityTypeBuilder<CampaignComment> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}
