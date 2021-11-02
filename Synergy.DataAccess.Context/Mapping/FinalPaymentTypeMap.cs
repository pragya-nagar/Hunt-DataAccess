using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class FinalPaymentTypeMap : IEntityTypeConfiguration<FinalPaymentType>
    {
        public void Configure(EntityTypeBuilder<FinalPaymentType> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasData(
               new FinalPaymentType { Id = 1, Name = "Wire", Description = "Wire", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-11"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-11") },
               new FinalPaymentType { Id = 2, Name = "CertifiedFunds", Description = "Certified Funds", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-11"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-11") },
               new FinalPaymentType { Id = 3, Name = "CompanyCheck", Description = "Company Check", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-11"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-11") });
        }
    }
}
