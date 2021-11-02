using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Synergy.DataAccess.Entities.OpportunityEntities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class OpportunityBorrowerBaseMap : IEntityTypeConfiguration<OpportunityBorrowerBase>
    {
        public void Configure(EntityTypeBuilder<OpportunityBorrowerBase> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
