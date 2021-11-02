using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class LeadCommentMap : IEntityTypeConfiguration<LeadComment>
    {
        public void Configure(EntityTypeBuilder<LeadComment> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}
