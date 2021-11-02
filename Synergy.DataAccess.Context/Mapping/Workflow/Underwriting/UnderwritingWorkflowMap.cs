using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class UnderwritingWorkflowMap : IEntityTypeConfiguration<UnderwritingWorkflow>
    {
        public void Configure(EntityTypeBuilder<UnderwritingWorkflow> builder)
        {
            builder.HasOne(x => x.Event).WithMany().HasForeignKey(x => x.EventId);
            builder.HasMany(x => x.Tasks).WithOne(x => x.Workflow).HasForeignKey(x => x.WorkflowId);
        }
    }
}