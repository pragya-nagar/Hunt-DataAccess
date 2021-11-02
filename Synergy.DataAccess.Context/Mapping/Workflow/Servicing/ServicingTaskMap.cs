using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class ServicingTaskMap : IEntityTypeConfiguration<ServicingTask>
    {
        public void Configure(EntityTypeBuilder<ServicingTask> builder)
        {
        }
    }
}