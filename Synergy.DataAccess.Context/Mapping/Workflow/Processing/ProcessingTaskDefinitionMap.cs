using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class ProcessingTaskDefinitionMap : IEntityTypeConfiguration<ProcessingTaskDefinition>
    {
        public void Configure(EntityTypeBuilder<ProcessingTaskDefinition> builder)
        {
            builder.HasMany(x => x.Tasks).WithOne(x => x.TaskDefinition).HasForeignKey(x => x.TaskDefinitionId);
            builder.HasMany(x => x.Workflows).WithOne(x => x.TaskDefinition).HasForeignKey(x => x.TaskDefinitionId);

            builder.HasData(
                new UnderwritingTaskDefinition { Id = Guid.Parse("00000000-0000-0000-0002-000000000001"), Name = "File Started", LogicTypeId = 1, TriggerDayOffset = 1, NotificationType = 3, IsActive = true, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-06-27"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-06-27") },
                new UnderwritingTaskDefinition { Id = Guid.Parse("00000000-0000-0000-0002-000000000002"), Name = "Disclosure", LogicTypeId = 2, TriggerDayOffset = 1, NotificationType = 3, IsActive = true, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-06-27"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-06-27") },
                new UnderwritingTaskDefinition { Id = Guid.Parse("00000000-0000-0000-0002-000000000003"), Name = "Processing", LogicTypeId = 3, TriggerDayOffset = 1, NotificationType = 3, IsActive = true, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-06-27"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-06-27") },
                new UnderwritingTaskDefinition { Id = Guid.Parse("00000000-0000-0000-0002-000000000004"), Name = "Assignment", LogicTypeId = 4, TriggerDayOffset = 1, NotificationType = 3, IsActive = true, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-06-27"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-06-27") },
                new UnderwritingTaskDefinition { Id = Guid.Parse("00000000-0000-0000-0002-000000000005"), Name = "Loan Approved", LogicTypeId = 5, TriggerDayOffset = 1, NotificationType = 3, IsActive = true, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-06-27"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-06-27") },
                new UnderwritingTaskDefinition { Id = Guid.Parse("00000000-0000-0000-0002-000000000006"), Name = "Scheduled", LogicTypeId = 6, TriggerDayOffset = 1, NotificationType = 3, IsActive = true, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-06-27"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-06-27") },
                new UnderwritingTaskDefinition { Id = Guid.Parse("00000000-0000-0000-0002-000000000007"), Name = "Doc Sent", LogicTypeId = 7, TriggerDayOffset = 1, NotificationType = 3, IsActive = true, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-06-27"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-06-27") },
                new UnderwritingTaskDefinition { Id = Guid.Parse("00000000-0000-0000-0002-000000000008"), Name = "Funding", LogicTypeId = 8, TriggerDayOffset = 1, NotificationType = 3, IsActive = true, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-06-27"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-06-27") },
                new UnderwritingTaskDefinition { Id = Guid.Parse("00000000-0000-0000-0002-000000000009"), Name = "Approved With Condition", LogicTypeId = 9, TriggerDayOffset = 1, NotificationType = 3, IsActive = true, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-06-27"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-06-27") },
                new UnderwritingTaskDefinition { Id = Guid.Parse("00000000-0000-0000-0002-00000000000A"), Name = "Denied", LogicTypeId = 10, TriggerDayOffset = 1, NotificationType = 3, IsActive = true, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-06-27"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-06-27") },
                new UnderwritingTaskDefinition { Id = Guid.Parse("00000000-0000-0000-0002-00000000000B"), Name = "Closing Condition", LogicTypeId = 11, TriggerDayOffset = 1, NotificationType = 3, IsActive = true, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-06-27"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-06-27") },
                new UnderwritingTaskDefinition { Id = Guid.Parse("00000000-0000-0000-0002-00000000000C"), Name = "N Round Review", LogicTypeId = 12, TriggerDayOffset = -1, NotificationType = 3, IsActive = true, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-06-27"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-06-27") },
                new UnderwritingTaskDefinition { Id = Guid.Parse("00000000-0000-0000-0002-00000000000D"), Name = "Final Round Review", LogicTypeId = 13, TriggerDayOffset = 1, NotificationType = 3, IsActive = true, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-06-27"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-06-27") });
        }
    }
}