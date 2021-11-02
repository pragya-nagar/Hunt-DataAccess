using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class WorkflowContextMap : IEntityTypeConfiguration<WorkflowContext>
    {
        public void Configure(EntityTypeBuilder<WorkflowContext> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.Context).HasColumnType("json");
            builder.HasOne(x => x.Workflow).WithMany().HasForeignKey(x => x.WorkflowId);
        }
    }
}