using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class DataCutFieldTypeMap : IEntityTypeConfiguration<DataCutFieldType>
    {
        public void Configure(EntityTypeBuilder<DataCutFieldType> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasData(
               new DataCutFieldType() { Id = 1, Name = "Text", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-19"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-19") },
               new DataCutFieldType() { Id = 2, Name = "Numeric", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-19"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-19") });
        }
    }
}
