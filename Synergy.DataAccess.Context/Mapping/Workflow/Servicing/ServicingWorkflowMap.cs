using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class ServicingWorkflowMap : IEntityTypeConfiguration<ServicingWorkflow>
    {
        public void Configure(EntityTypeBuilder<ServicingWorkflow> builder)
        {
            builder.HasMany(x => x.Tasks).WithOne(x => x.Workflow).HasForeignKey(x => x.WorkflowId);
        }
    }
}