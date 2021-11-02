using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Synergy.DataAccess.Entities.OpportunityEntities;

namespace Synergy.DataAccess.Context.Mapping.Opportunity
{
    internal class OpportunityMonthlyPrepayMap : IEntityTypeConfiguration<OpportunityMonthlyPrepay>
    {
        // Monthly Prepay data
        public void Configure(EntityTypeBuilder<OpportunityMonthlyPrepay> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasData(
                new OpportunityMonthlyPrepay { Id = 1, MonthlyPrepay = 6, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-09-17"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-09-17") },
                new OpportunityMonthlyPrepay { Id = 2, MonthlyPrepay = 12, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-09-17"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-09-17") },
                new OpportunityMonthlyPrepay { Id = 3, MonthlyPrepay = 18, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-09-17"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-09-17") },
                new OpportunityMonthlyPrepay { Id = 4, MonthlyPrepay = 24, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-09-17"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-09-17") });
        }
    }
}
