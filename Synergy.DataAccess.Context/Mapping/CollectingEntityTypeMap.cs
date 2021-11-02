using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class CollectingEntityTypeMap : IEntityTypeConfiguration<CollectingEntityType>
    {
        public void Configure(EntityTypeBuilder<CollectingEntityType> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasData(
                new CampaignType { Id = 1, Name = "County", Description = "County", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-11"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-11") },
                new CampaignType { Id = 2, Name = "City", Description = "City", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-11"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-11") },
                new CampaignType { Id = 3, Name = "ISD", Description = "ISD", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-11"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-11") },
                new CampaignType { Id = 4, Name = "Other", Description = "Other", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-11"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-11") });
        }
    }
}
