using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Synergy.DataAccess.Entities.OpportunityEntities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class OpportunityContactMap : IEntityTypeConfiguration<OpportunityContact>
    {
        public void Configure(EntityTypeBuilder<OpportunityContact> builder)
        {
            builder.HasKey(oc => new { oc.OpportunityId, oc.ContactId });

            builder.HasOne(o => o.Opportunity)
                   .WithMany(oc => oc.OpportunityContacts)
                   .HasForeignKey(o => o.OpportunityId);

            builder.HasOne(c => c.Contact)
                   .WithMany(oc => oc.OpportunityContacts)
                   .HasForeignKey(c => c.ContactId);
        }
    }
}
