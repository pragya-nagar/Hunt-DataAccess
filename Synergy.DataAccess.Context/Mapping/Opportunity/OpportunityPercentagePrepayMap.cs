using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Synergy.DataAccess.Entities.OpportunityEntities;

namespace Synergy.DataAccess.Context.Mapping.Opportunity
{
    internal class OpportunityPercentagePrepayMap : IEntityTypeConfiguration<OpportunityPercentagePrepay>
    {
        public void Configure(EntityTypeBuilder<OpportunityPercentagePrepay> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasData(
                new OpportunityPercentagePrepay { Id = 1, PercentagePrepay = 0.5m, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-09-17"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-09-17") },
                new OpportunityPercentagePrepay { Id = 2, PercentagePrepay = 1.0m, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-09-17"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-09-17") },
                new OpportunityPercentagePrepay { Id = 3, PercentagePrepay = 1.5m, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-09-17"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-09-17") },
                new OpportunityPercentagePrepay { Id = 4, PercentagePrepay = 2.0m, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-09-17"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-09-17") },
                new OpportunityPercentagePrepay { Id = 5, PercentagePrepay = 2.5m, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-09-17"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-09-17") },
                new OpportunityPercentagePrepay { Id = 6, PercentagePrepay = 3.0m, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-09-17"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-09-17") });
        }
    }
}
