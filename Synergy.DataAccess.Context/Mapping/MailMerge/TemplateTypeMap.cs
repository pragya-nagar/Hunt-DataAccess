using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;
using Synergy.DataAccess.Enum;

namespace Synergy.DataAccess.Context.Mapping.MailMerge
{
    public class TemplateTypeMap : IEntityTypeConfiguration<TemplateType>
    {
        public void Configure(EntityTypeBuilder<TemplateType> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Module).WithMany(x => x.TemplateTypes);

            builder.HasData(
                new TemplateType
                {
                    Id = 1,
                    Name = "Pre-Sale Letters",
                    GroupingType = (int)MergeFieldsGroupingType.PerOwner,
                    ModuleId = 1,
                    CreatedById = Common.Constants.User.SystemUserId, ModifiedById = Common.Constants.User.SystemUserId,
                    CreatedOn = DateTime.Parse("2019-05-07"), ModifiedOn = DateTime.Parse("2019-05-07"),
                },
                new TemplateType
                {
                    Id = 2,
                    Name = "Post-Sale Letters",
                    GroupingType = (int)MergeFieldsGroupingType.PerOwner,
                    ModuleId = 1,
                    CreatedById = Common.Constants.User.SystemUserId, ModifiedById = Common.Constants.User.SystemUserId,
                    CreatedOn = DateTime.Parse("2019-05-07"), ModifiedOn = DateTime.Parse("2019-05-07"),
                },
                new TemplateType
                {
                    Id = 3,
                    Name = "Certificates",
                    GroupingType = (int)MergeFieldsGroupingType.PerDelinquency,
                    ModuleId = 1,
                    CreatedById = Common.Constants.User.SystemUserId, ModifiedById = Common.Constants.User.SystemUserId,
                    CreatedOn = DateTime.Parse("2019-05-07"), ModifiedOn = DateTime.Parse("2019-05-07"),
                },
                new TemplateType
                {
                    Id = 4,
                    Name = "Default",
                    GroupingType = (int)MergeFieldsGroupingType.PerDelinquency,
                    ModuleId = 2,
                    CreatedById = Common.Constants.User.SystemUserId, ModifiedById = Common.Constants.User.SystemUserId,
                    CreatedOn = DateTime.Parse("2019-05-07"), ModifiedOn = DateTime.Parse("2019-05-07"),
                },
                new TemplateType
                {
                    Id = 5,
                    Name = "Customer Quotes",
                    GroupingType = (int)MergeFieldsGroupingType.PerDelinquency,
                    ModuleId = 2,
                    CreatedById = Common.Constants.User.SystemUserId,
                    ModifiedById = Common.Constants.User.SystemUserId,
                    CreatedOn = DateTime.Parse("2019-11-11"),
                    ModifiedOn = DateTime.Parse("2019-11-11"),
                });
        }
    }
}