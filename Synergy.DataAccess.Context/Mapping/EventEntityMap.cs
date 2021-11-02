using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    internal class EventEntityMap : IEntityTypeConfiguration<EventEntity>
    {
        public void Configure(EntityTypeBuilder<EventEntity> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasData(
               new EventEntity { Id = 1, Name = "TEF1", Description = "TEF-1", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-11"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-11") },
               new EventEntity { Id = 2, Name = "Caz", Description = "Caz", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-11"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-11") },
               new EventEntity { Id = 3, Name = "CCF1", Description = "CCF 1", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-11"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-11") },
               new EventEntity { Id = 4, Name = "TaxEaseOhioII", Description = "'Tax Ease Ohio II", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-11"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-11") },
               new EventEntity { Id = 5, Name = "CCFII", Description = "CCF II", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-11"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-11") });
        }
    }
}
