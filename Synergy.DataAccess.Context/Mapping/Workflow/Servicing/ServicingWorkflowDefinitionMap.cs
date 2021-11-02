using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class ServicingWorkflowDefinitionMap : IEntityTypeConfiguration<ServicingWorkflowDefinition>
    {
        public void Configure(EntityTypeBuilder<ServicingWorkflowDefinition> builder)
        {
            builder.HasMany(x => x.Tasks).WithOne(x => x.WorkflowDefinition).HasForeignKey(x => x.WorkflowDefinitionId);
        }
    }
}