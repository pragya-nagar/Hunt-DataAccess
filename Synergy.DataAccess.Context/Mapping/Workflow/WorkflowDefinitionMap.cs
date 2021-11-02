using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class WorkflowDefinitionMap : IEntityTypeConfiguration<WorkflowDefinition>
    {
        public void Configure(EntityTypeBuilder<WorkflowDefinition> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.HasDiscriminator<int>("WorkflowType")
                .HasValue<UnderwritingWorkflowDefinition>(1)
                .HasValue<ProcessingWorkflowDefinition>(2)
                .HasValue<ServicingWorkflowDefinition>(3);
        }
    }
}