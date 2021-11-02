using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class PropertyProfileLogicTypeMap : IEntityTypeConfiguration<PropertyProfileLogicType>
    {
        public void Configure(EntityTypeBuilder<PropertyProfileLogicType> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasData(
                new PropertyProfileLogicType { Id = 1, Name = "Include", Description = "Include", PropertyProfileFieldTypeId = 1, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-02-25"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-02-25") },
                new PropertyProfileLogicType { Id = 2, Name = "Exclude", Description = "Exclude", PropertyProfileFieldTypeId = 1, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-02-25"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-02-25") },
                new PropertyProfileLogicType { Id = 3, Name = "LessThan", Description = "Less Than", PropertyProfileFieldTypeId = 2, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-02-25"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-02-25") },
                new PropertyProfileLogicType { Id = 4, Name = "LessThanOrEqual", Description = "Less Than Or Equal", PropertyProfileFieldTypeId = 2, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-02-25"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-02-25") },
                new PropertyProfileLogicType { Id = 5, Name = "GreaterThan", Description = "Greater Than", PropertyProfileFieldTypeId = 2, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-02-25"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-02-25") },
                new PropertyProfileLogicType { Id = 6, Name = "GreaterThanOrEqual", Description = "Greater Than Or Equal", PropertyProfileFieldTypeId = 2, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-02-25"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-02-25") });
        }
    }
}