using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class WorkflowMap : IEntityTypeConfiguration<Workflow>
    {
        public void Configure(EntityTypeBuilder<Workflow> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.HasDiscriminator<int>("WorkflowType")
                .HasValue<UnderwritingWorkflow>(1)
                .HasValue<ProcessingWorkflow>(2)
                .HasValue<ServicingWorkflow>(3);
        }
    }
}