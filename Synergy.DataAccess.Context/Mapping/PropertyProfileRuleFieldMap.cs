using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class PropertyProfileRuleFieldMap : IEntityTypeConfiguration<PropertyProfileRuleField>
    {
        public void Configure(EntityTypeBuilder<PropertyProfileRuleField> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasData(
                new PropertyProfileRuleField { Id = 1, Name = "General Land Use Code", Description = "General Land Use Code", PropertyProfileFieldTypeId = 1, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-02-22"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-02-22") },
                new PropertyProfileRuleField { Id = 2, Name = "Internal Land Use Code", Description = "Internal Land Use Code", PropertyProfileFieldTypeId = 1, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-02-22"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-02-22") },
                new PropertyProfileRuleField { Id = 3, Name = "Land Use Codes", Description = "Land Use Codes", PropertyProfileFieldTypeId = 1, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-02-22"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-02-22") },
                new PropertyProfileRuleField { Id = 4, Name = "Total Due Amount", Description = "Total Due Amount", PropertyProfileFieldTypeId = 2, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-02-22"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-02-22") },
                new PropertyProfileRuleField { Id = 5, Name = "Assessed Value", Description = "Assessed Value", PropertyProfileFieldTypeId = 2, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-02-22"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-02-22") },
                new PropertyProfileRuleField { Id = 6, Name = "LTV", Description = "LTV %", PropertyProfileFieldTypeId = 2, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-02-22"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-02-22") },
                new PropertyProfileRuleField { Id = 7, Name = "RULTV", Description = "RU LTV%", PropertyProfileFieldTypeId = 2, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-02-22"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-02-22") });
        }
    }
}
