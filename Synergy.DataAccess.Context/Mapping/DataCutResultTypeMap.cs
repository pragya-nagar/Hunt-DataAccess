using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class DataCutResultTypeMap : IEntityTypeConfiguration<DataCutResultType>
    {
        public void Configure(EntityTypeBuilder<DataCutResultType> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasData(
                new DataCutResultType { Id = 1, Name = "DataReject", Description = "Data Reject", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-19"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-19") },
                new DataCutResultType { Id = 2, Name = "DataApprove", Description = "Data Approve", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-19"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-19") });
        }
    }
}
