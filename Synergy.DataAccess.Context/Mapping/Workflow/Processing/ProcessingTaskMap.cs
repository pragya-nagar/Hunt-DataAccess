using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class ProcessingTaskMap : IEntityTypeConfiguration<ProcessingTask>
    {
        public void Configure(EntityTypeBuilder<ProcessingTask> builder)
        {
        }
    }
}