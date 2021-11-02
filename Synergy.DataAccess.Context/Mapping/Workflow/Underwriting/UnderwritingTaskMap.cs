using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class UnderwritingTaskMap : IEntityTypeConfiguration<UnderwritingTask>
    {
        public void Configure(EntityTypeBuilder<UnderwritingTask> builder)
        {
        }
    }
}