using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class LeadSourceMap : IEntityTypeConfiguration<LeadSourceType>
    {
        public void Configure(EntityTypeBuilder<LeadSourceType> builder)
        {
            // Seed Data
            builder.HasKey(e => e.Id);
            builder.HasData(
               new LeadSourceType { Id = 1, LeadSource = "Internet", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-10-11"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-10-11") },
               new LeadSourceType { Id = 2, LeadSource = "Mailer", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-10-11"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-10-11") },
               new LeadSourceType { Id = 3, LeadSource = "Outbound Call", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-10-11"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-10-11") },
               new LeadSourceType { Id = 4, LeadSource = "Outbound Email", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-10-11"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-10-11") },
               new LeadSourceType { Id = 5, LeadSource = "Referral", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-10-11"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-10-11") },
               new LeadSourceType { Id = 6, LeadSource = "Previous Inbound", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-10-11"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-10-11") },
               new LeadSourceType { Id = 7, LeadSource = "Current Inbound", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-10-11"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-10-11") },
               new LeadSourceType { Id = 8, LeadSource = "Commercial Trip", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-10-11"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-10-11") });
        }
    }
}
