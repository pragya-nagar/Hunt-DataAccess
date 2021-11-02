using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class UnderwritingWorkflowDefinitionMap : IEntityTypeConfiguration<UnderwritingWorkflowDefinition>
    {
        public void Configure(EntityTypeBuilder<UnderwritingWorkflowDefinition> builder)
        {
            builder.HasMany(x => x.Tasks).WithOne(x => x.WorkflowDefinition).HasForeignKey(x => x.WorkflowDefinitionId);
            builder.HasMany(x => x.States).WithOne(x => x.WorkflowDefinition).HasForeignKey(x => x.WorkflowDefinitionId);
            builder.HasMany(x => x.EventTypes).WithOne(x => x.WorkflowDefinition).HasForeignKey(x => x.WorkflowDefinitionId);
        }
    }
}