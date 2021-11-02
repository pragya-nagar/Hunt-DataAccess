using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Synergy.DataAccess.Entities.Processing;

namespace Synergy.DataAccess.Context.Mapping.Processing
{
    public class LoanMap : IEntityTypeConfiguration<Loan>
    {
        public void Configure(EntityTypeBuilder<Loan> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Officer).WithMany().HasForeignKey(x => x.OfficerId);

            builder.HasOne(x => x.Stage).WithMany().HasForeignKey(x => x.StageId);
            builder.HasOne(x => x.LoanType).WithMany().HasForeignKey(x => x.LoanTypeId);
            builder.HasOne(x => x.LoanPropertyType).WithMany().HasForeignKey(x => x.LoanPropertyTypeId);

            builder.HasOne(x => x.EntityBorrower).WithOne(x => x.Loan).HasForeignKey<EntityBorrower>(x => x.LoanId);
            builder.HasMany(x => x.Borrowers).WithOne(x => x.Loan).HasForeignKey(x => x.LoanId);
        }
    }
}
