using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class DecisionTypeMap : IEntityTypeConfiguration<DecisionType>
    {
        public void Configure(EntityTypeBuilder<DecisionType> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasData(
                new EventType { Id = 1, Name = "Reject", Description = "Reject", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-11"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-11") },
                new EventType { Id = 2, Name = "Approve", Description = "Approve", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-11"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-11") },
                new EventType { Id = 3, Name = "AutoReject", Description = "Auto Reject", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-11"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-11") },
                new EventType { Id = 4, Name = "AutoApprove", Description = "Auto Approve", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-11"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-11") },
                new EventType { Id = 5, Name = "ManualReview", Description = "Manual Review", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-11"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-11") },
                new EventType { Id = 6, Name = "Research", Description = "Research", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-11"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-11") });
        }
    }
}
