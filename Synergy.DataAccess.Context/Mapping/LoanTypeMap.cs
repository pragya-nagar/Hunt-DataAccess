using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    internal class LoanTypeMap : IEntityTypeConfiguration<LoanType>
    {
        public void Configure(EntityTypeBuilder<LoanType> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasData(
               new LoanType { Id = 1, Name = "New", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-06-26"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-06-26") },
               new LoanType { Id = 2, Name = "NewConsolidation", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-06-26"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-06-26") },
               new LoanType { Id = 3, Name = "Refi", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-06-26"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-06-26") },
               new LoanType { Id = 4, Name = "RefiConsolidation", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-06-26"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-06-26") },
               new LoanType { Id = 5, Name = "Syl", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-06-26"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-06-26") },
               new LoanType { Id = 6, Name = "SylConsolidation", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-06-26"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-06-26") });
        }
    }
}
