using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Synergy.DataAccess.Entities.OpportunityEntities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class OpportunityMap : IEntityTypeConfiguration<Synergy.DataAccess.Entities.OpportunityEntities.Opportunity>
    {
        public void Configure(EntityTypeBuilder<Synergy.DataAccess.Entities.OpportunityEntities.Opportunity> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasIndex(o => o.OpportunityNumber).IsUnique();

            builder.HasMany(x => x.OpportunityBorrowers).WithOne(x => x.Opportunity).HasForeignKey(x => x.OpportunityId);
            builder.HasMany(x => x.OpportunityCommercialBorrowers).WithOne(x => x.Opportunity).HasForeignKey(x => x.OpportunityId);
        }
    }
}
