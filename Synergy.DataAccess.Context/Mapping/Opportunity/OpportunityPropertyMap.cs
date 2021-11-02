using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Synergy.DataAccess.Entities.OpportunityEntities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class OpportunityPropertyMap : IEntityTypeConfiguration<OpportunityProperty>
    {
        public void Configure(EntityTypeBuilder<OpportunityProperty> builder)
        {
            builder.HasKey(od => new { od.PropertyId, od.OpportunityId });

            builder.HasOne(o => o.Opportunity)
                .WithMany(od => od.OpportunityProperties)
                .HasForeignKey(o => o.OpportunityId);

            builder.HasOne(d => d.Property)
                .WithMany(od => od.OpportunityProperties)
                .HasForeignKey(d => d.PropertyId);
        }
    }
}
