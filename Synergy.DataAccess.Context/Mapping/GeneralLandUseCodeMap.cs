using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class GeneralLandUseCodeMap : IEntityTypeConfiguration<GeneralLandUseCode>
    {
        public void Configure(EntityTypeBuilder<GeneralLandUseCode> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasData(
               new EventType { Id = 1, Name = "Residential", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-11"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-11") },
               new EventType { Id = 2, Name = "Commercial", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-11"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-11") },
               new EventType { Id = 3, Name = "Agricultural", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-15"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-15") },
               new EventType { Id = 4, Name = "Vacant", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-15"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-15") },
               new EventType { Id = 5, Name = "Unknown", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-15"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-15") });
        }
    }
}
