using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class OperationStatusMap : IEntityTypeConfiguration<OperationStatus>
    {
        public void Configure(EntityTypeBuilder<OperationStatus> builder)
        {
            builder.HasKey(x => new { x.Id, x.CreatedOn });
            builder.HasIndex(x => x.Code);
        }
    }
}
