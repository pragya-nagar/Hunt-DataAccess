using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class CollectingEntityMap : IEntityTypeConfiguration<CollectingEntity>
    {
        public void Configure(EntityTypeBuilder<CollectingEntity> modelBuilder)
        {
            modelBuilder.HasKey(x => x.Id);
            modelBuilder.Property(x => x.AmountDue).HasColumnType("decimal(19,4)");
        }
    }
}
