using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class PropertyProfileFieldTypeMap : IEntityTypeConfiguration<PropertyProfileFieldType>
    {
        public void Configure(EntityTypeBuilder<PropertyProfileFieldType> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasData(
                new PropertyProfileFieldType { Id = 1, Name = "MultipleValue", Description = "Multiple Value", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-02-25"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-02-25") },
                new PropertyProfileFieldType { Id = 2, Name = "Numeric", Description = "Numeric", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-02-25"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-02-25") });
        }
    }
}
