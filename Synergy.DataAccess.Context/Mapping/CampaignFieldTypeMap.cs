using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class CampaignFieldTypeMap : IEntityTypeConfiguration<CampaignFieldType>
    {
        public void Configure(EntityTypeBuilder<CampaignFieldType> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasData(
                new CampaignFieldType() { Id = 1, Name = "Text", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-24"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-24") },
                new CampaignFieldType() { Id = 2, Name = "Numeric", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-24"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-24") },
                new CampaignFieldType() { Id = 3, Name = "ShortcutedLogicText", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-24"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-24") });
        }
    }
}
