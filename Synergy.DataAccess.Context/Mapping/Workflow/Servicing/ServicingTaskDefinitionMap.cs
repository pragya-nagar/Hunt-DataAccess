using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class ServicingTaskDefinitionMap : IEntityTypeConfiguration<ServicingTaskDefinition>
    {
        public void Configure(EntityTypeBuilder<ServicingTaskDefinition> builder)
        {
            builder.HasMany(x => x.Tasks).WithOne(x => x.TaskDefinition).HasForeignKey(x => x.TaskDefinitionId);
            builder.HasMany(x => x.Workflows).WithOne(x => x.TaskDefinition).HasForeignKey(x => x.TaskDefinitionId);
        }
    }
}