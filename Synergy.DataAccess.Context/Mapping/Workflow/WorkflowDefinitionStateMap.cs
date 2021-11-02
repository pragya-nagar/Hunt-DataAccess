using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class WorkflowDefinitionStateMap : IEntityTypeConfiguration<WorkflowDefinitionState>
    {
        public void Configure(EntityTypeBuilder<WorkflowDefinitionState> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasOne(x => x.State).WithMany().HasForeignKey(x => x.StateId);

            builder.HasDiscriminator<int>("WorkflowType")
                .HasValue<UnderwritingWorkflowDefinitionState>(1)
                .HasValue<ProcessingWorkflowDefinitionState>(2);
        }
    }
}
