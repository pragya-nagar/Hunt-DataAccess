using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class DataCutLogicTypeMap : IEntityTypeConfiguration<DataCutLogicType>
    {
        public void Configure(EntityTypeBuilder<DataCutLogicType> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasData(
                new DataCutLogicType { Id = 1, Name = "Contains", Description = "Contains", DataCutFieldTypeId = 1, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-18"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-18") },
                new DataCutLogicType { Id = 2, Name = "DoesNotContain", Description = "Does Not Contain", DataCutFieldTypeId = 1, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018 -12-18"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-18") },
                new DataCutLogicType { Id = 3, Name = "Equal", Description = "Equal", DataCutFieldTypeId = 1, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-18"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-18") },
                new DataCutLogicType { Id = 4, Name = "NotEqual", Description = "Not Equal", DataCutFieldTypeId = 1, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-18"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-18") },
                new DataCutLogicType { Id = 5, Name = "LessThan", Description = "Less Than", DataCutFieldTypeId = 2, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-18"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-18") },
                new DataCutLogicType { Id = 6, Name = "LessThanOrEqual", Description = "Less Than Or Equal", DataCutFieldTypeId = 2, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-18"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-18") },
                new DataCutLogicType { Id = 7, Name = "GreaterThan", Description = "Greater Than", DataCutFieldTypeId = 2, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-18"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-18") },
                new DataCutLogicType { Id = 8, Name = "GreaterThanOrEqual", Description = "Greater Than Or Equal", DataCutFieldTypeId = 2, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-18"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-18") });
        }
    }
}
