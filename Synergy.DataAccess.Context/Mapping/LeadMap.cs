using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class LeadMap : IEntityTypeConfiguration<Lead>
    {
        public void Configure(EntityTypeBuilder<Lead> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasIndex(b => b.LeadBK);
            builder.HasOne(x => x.LeadSourceType).WithMany().HasForeignKey(x => x.LeadSourceId);
        }
    }
}
