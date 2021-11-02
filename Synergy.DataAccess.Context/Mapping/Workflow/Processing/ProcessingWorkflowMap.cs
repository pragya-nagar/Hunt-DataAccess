using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class ProcessingWorkflowMap : IEntityTypeConfiguration<ProcessingWorkflow>
    {
        public void Configure(EntityTypeBuilder<ProcessingWorkflow> builder)
        {
            builder.HasOne(x => x.Loan).WithMany().HasForeignKey(x => x.LoanId);
            builder.HasMany(x => x.Tasks).WithOne(x => x.Workflow).HasForeignKey(x => x.WorkflowId);
        }
    }
}