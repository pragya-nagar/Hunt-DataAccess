using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class ContactTypeMap : IEntityTypeConfiguration<ContactType>
    {
        public void Configure(EntityTypeBuilder<ContactType> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasData(
              new EventType { Id = 1, Name = "SOSResearch", Description = "SOS Research", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-11"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-11") },
              new EventType { Id = 2, Name = "Other", Description = "Other", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-11"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-11") });
        }
    }
}
