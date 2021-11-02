using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping.MailMerge
{
    public class ModuleMap : IEntityTypeConfiguration<Module>
    {
        public void Configure(EntityTypeBuilder<Module> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasData(
                new Module
                {
                    Id = 1, Name = "Underwriting",
                    CreatedById = Common.Constants.User.SystemUserId, ModifiedById = Common.Constants.User.SystemUserId,
                    CreatedOn = DateTime.Parse("2019-05-07"), ModifiedOn = DateTime.Parse("2019-05-07"),
                },
                new Module
                {
                    Id = 2, Name = "CRM",
                    CreatedById = Common.Constants.User.SystemUserId, ModifiedById = Common.Constants.User.SystemUserId,
                    CreatedOn = DateTime.Parse("2019-05-07"), ModifiedOn = DateTime.Parse("2019-05-07"),
                });
        }
    }
}
