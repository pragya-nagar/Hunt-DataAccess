using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Synergy.DataAccess.Entities.Processing;

namespace Synergy.DataAccess.Context.Mapping.Processing
{
    public class LoanPropertyMap : IEntityTypeConfiguration<LoanProperty>
    {
        public void Configure(EntityTypeBuilder<LoanProperty> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Loan)
                .WithMany(x => x.LoanProperties)
                .HasForeignKey(x => x.LoanId);

            builder.HasOne(x => x.Property)
                .WithMany(x => x.LoanProperties)
                .HasForeignKey(x => x.PropertyId);
        }
    }
}
