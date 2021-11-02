using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class PropertyDisplayStrategyMap : IEntityTypeConfiguration<PropertyDisplayStrategy>
    {
        public void Configure(EntityTypeBuilder<PropertyDisplayStrategy> builder)
        {
            builder.HasKey(e => e.Id);

            // TODO add name
            builder.HasData(
              new PropertyDisplayStrategy { Id = 1, Name = "DoNotBuySubs_NonAccrual", Description = "DO NOT BUY SUBS/NON-ACCRUAL", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-25"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-25") },
              new PropertyDisplayStrategy { Id = 2, Name = "ForeclosureImmediately", Description = "FORECLOSURE IMMEDIATELY", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-25"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-25") },
              new PropertyDisplayStrategy { Id = 3, Name = "Hold", Description = "HOLD", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-25"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-25") },
              new PropertyDisplayStrategy { Id = 4, Name = "SeekSie", Description = "SEEK SIE", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-25"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-25") },
              new PropertyDisplayStrategy { Id = 5, Name = "SeekToAssign", Description = "SEEK TO ASSIGN", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-25"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-25") },
              new PropertyDisplayStrategy { Id = 6, Name = "SettleWithOwner", Description = "SETTLE WITH OWNER", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-25"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-25") });
        }
    }
}
