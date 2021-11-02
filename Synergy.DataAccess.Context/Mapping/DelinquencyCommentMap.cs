using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class DelinquencyCommentMap : IEntityTypeConfiguration<DelinquencyComment>
    {
        public void Configure(EntityTypeBuilder<DelinquencyComment> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}
