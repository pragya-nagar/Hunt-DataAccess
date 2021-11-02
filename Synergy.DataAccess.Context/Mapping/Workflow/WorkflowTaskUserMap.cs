using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class WorkflowTaskUserMap : IEntityTypeConfiguration<TaskUser>
    {
        public void Configure(EntityTypeBuilder<TaskUser> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();

            builder.HasOne(x => x.User).WithMany().HasForeignKey(x => x.UserId);
        }
    }
}