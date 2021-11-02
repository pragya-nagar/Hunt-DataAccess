using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class TaskMap : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.InstanceNumber).HasDefaultValue(1);
            builder.Property(x => x.CompletionType).HasDefaultValue(2);
            builder.Property(x => x.Status).HasDefaultValue(0);
            builder.HasMany(x => x.Users).WithOne(x => x.Task).HasForeignKey(x => x.TaskId);
            builder.HasDiscriminator<int>("WorkflowType")
                .HasValue<UnderwritingTask>(1)
                .HasValue<ProcessingTask>(2)
                .HasValue<ServicingTask>(3);
        }
    }
}
