using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    internal class SaleDateStatusMap : IEntityTypeConfiguration<SaleDateStatus>
    {
        public void Configure(EntityTypeBuilder<SaleDateStatus> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasData(
               new SaleDateStatus { Id = 1, Name = "Estimate", Description = "Estimate", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-11"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-11") },
               new SaleDateStatus { Id = 2, Name = "Confirmed", Description = "Confirmed", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-11"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-11") });
        }
    }
}
