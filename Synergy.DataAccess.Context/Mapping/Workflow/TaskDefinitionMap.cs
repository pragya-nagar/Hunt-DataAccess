using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class TaskDefinitionMap : IEntityTypeConfiguration<TaskDefinition>
    {
        public void Configure(EntityTypeBuilder<TaskDefinition> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.TriggerDayOffset).HasDefaultValue(0);
            builder.Property(x => x.TriggerSourceTypeId).HasDefaultValue(1);
            builder.Property(x => x.NotificationType).HasDefaultValue(0);
            builder.HasMany(x => x.Users).WithOne(x => x.TaskDefinition).HasForeignKey(x => x.TaskDefinitionId);
            builder.HasMany(x => x.Departments).WithOne(x => x.TaskDefinition).HasForeignKey(x => x.TaskDefinitionId);
            builder.HasDiscriminator<int>("WorkflowType")
                .HasValue<UnderwritingTaskDefinition>(1)
                .HasValue<ProcessingTaskDefinition>(2)
                .HasValue<ServicingTaskDefinition>(3);
        }
    }
}