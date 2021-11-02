using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    internal class CampaignLogicTypeMap : IEntityTypeConfiguration<CampaignLogicType>
    {
        public void Configure(EntityTypeBuilder<CampaignLogicType> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasData(
                new CampaignLogicType { Id = 1, Name = "Contains", Description = "Contains", CampaignFieldTypeId = 1, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-24"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-24") },
                new CampaignLogicType { Id = 2, Name = "DoesNotContain", Description = "Does Not Contain", CampaignFieldTypeId = 1, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018 -12-24"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-24") },
                new CampaignLogicType { Id = 3, Name = "Equal", Description = "Equal", CampaignFieldTypeId = 1, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-24"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-24") },
                new CampaignLogicType { Id = 4, Name = "NotEqual", Description = "Not Equal", CampaignFieldTypeId = 1, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-24"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-24") },
                new CampaignLogicType { Id = 5, Name = "LessThan", Description = "Less Than", CampaignFieldTypeId = 2, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-24"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-24") },
                new CampaignLogicType { Id = 6, Name = "LessThanOrEqual", Description = "Less Than Or Equal", CampaignFieldTypeId = 2, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-24"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-24") },
                new CampaignLogicType { Id = 7, Name = "GreaterThan", Description = "Greater Than", CampaignFieldTypeId = 2, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-24"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-24") },
                new CampaignLogicType { Id = 8, Name = "GreaterThanOrEqual", Description = "Greater Than Or Equal", CampaignFieldTypeId = 2, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-24"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-24") },
                new CampaignLogicType { Id = 9, Name = "Equal", Description = "Equal", CampaignFieldTypeId = 3, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-24"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-24") },
                new CampaignLogicType { Id = 10, Name = "NotEqual", Description = "Not Equal", CampaignFieldTypeId = 3, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-24"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-24") });
        }
    }
}
