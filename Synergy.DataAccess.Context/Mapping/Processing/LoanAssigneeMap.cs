using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Synergy.DataAccess.Entities.Processing;

namespace Synergy.DataAccess.Context.Mapping
{
    internal class LoanAssigneeMap : IEntityTypeConfiguration<LoanAssignee>
    {
        public void Configure(EntityTypeBuilder<LoanAssignee> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Loan).WithMany(x => x.Assignees).HasForeignKey(x => x.LoanId);

            builder.HasOne(x => x.User).WithMany().HasForeignKey(x => x.UserId);
        }
    }
}
