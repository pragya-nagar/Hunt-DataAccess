using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class UnderwritingWorkflowTaskDefinitionMap : IEntityTypeConfiguration<UnderwritingWorkflowTaskDefinition>
    {
        public void Configure(EntityTypeBuilder<UnderwritingWorkflowTaskDefinition> builder)
        {
            builder.Property(x => x.DependencyTypeId).HasDefaultValue(1);
            builder.HasMany(x => x.Dependencies).WithOne(x => x.Dependency).HasForeignKey(x => x.DependencyId);
        }
    }
}