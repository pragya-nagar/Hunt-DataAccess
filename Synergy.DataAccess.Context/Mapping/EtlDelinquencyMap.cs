using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class EtlDelinquencyMap : IEntityTypeConfiguration<EtlDelinquency>
    {
        public void Configure(EntityTypeBuilder<EtlDelinquency> builder)
        {
            builder.HasKey(x => new { x.DelinquencyId, x.EventId });
        }
    }
}
