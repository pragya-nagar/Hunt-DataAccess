using System;
using System.ComponentModel;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Synergy.DataAccess.Entities.Processing;

namespace Synergy.DataAccess.Context.Mapping.Processing
{
    using LoanStageEnum = Synergy.DataAccess.Enum.Processing.LoanStage;

    public class LoanStageMap : IEntityTypeConfiguration<LoanStage>
    {
        public void Configure(EntityTypeBuilder<LoanStage> builder)
        {
            var systemUser = Synergy.Common.Constants.User.SystemUserId;

            builder.HasKey(x => x.Id);

            builder.HasData(
                new LoanStage { Id = (int)LoanStageEnum.FileStarted, CreatedOn = DateTime.Parse("2019-06-24"), CreatedById = systemUser, ModifiedOn = DateTime.Parse("2019-06-24"), ModifiedById = systemUser, Name = System.Enum.GetName(typeof(LoanStageEnum), LoanStageEnum.FileStarted), Description = GetDescription(LoanStageEnum.FileStarted), },
                new LoanStage { Id = (int)LoanStageEnum.Disclosed, CreatedOn = DateTime.Parse("2019-06-24"), CreatedById = systemUser, ModifiedOn = DateTime.Parse("2019-06-24"), ModifiedById = systemUser, Name = System.Enum.GetName(typeof(LoanStageEnum), LoanStageEnum.Disclosed), Description = GetDescription(LoanStageEnum.Disclosed), },
                new LoanStage { Id = (int)LoanStageEnum.Processing, CreatedOn = DateTime.Parse("2019-06-24"), CreatedById = systemUser, ModifiedOn = DateTime.Parse("2019-06-24"), ModifiedById = systemUser, Name = System.Enum.GetName(typeof(LoanStageEnum), LoanStageEnum.Processing), Description = GetDescription(LoanStageEnum.Processing), },
                new LoanStage { Id = (int)LoanStageEnum.Underwriting, CreatedOn = DateTime.Parse("2019-06-24"), CreatedById = systemUser, ModifiedOn = DateTime.Parse("2019-06-24"), ModifiedById = systemUser, Name = System.Enum.GetName(typeof(LoanStageEnum), LoanStageEnum.Underwriting), Description = GetDescription(LoanStageEnum.Underwriting), },
                new LoanStage { Id = (int)LoanStageEnum.Scheduled, CreatedOn = DateTime.Parse("2019-06-24"), CreatedById = systemUser, ModifiedOn = DateTime.Parse("2019-06-24"), ModifiedById = systemUser, Name = System.Enum.GetName(typeof(LoanStageEnum), LoanStageEnum.Scheduled), Description = GetDescription(LoanStageEnum.Scheduled), },
                new LoanStage { Id = (int)LoanStageEnum.DocsSent, CreatedOn = DateTime.Parse("2019-06-24"), CreatedById = systemUser, ModifiedOn = DateTime.Parse("2019-06-24"), ModifiedById = systemUser, Name = System.Enum.GetName(typeof(LoanStageEnum), LoanStageEnum.DocsSent), Description = GetDescription(LoanStageEnum.DocsSent), },
                new LoanStage { Id = (int)LoanStageEnum.Funded, CreatedOn = DateTime.Parse("2019-06-24"), CreatedById = systemUser, ModifiedOn = DateTime.Parse("2019-06-24"), ModifiedById = systemUser, Name = System.Enum.GetName(typeof(LoanStageEnum), LoanStageEnum.Funded), Description = GetDescription(LoanStageEnum.Funded), },
                new LoanStage { Id = (int)LoanStageEnum.Completion, CreatedOn = DateTime.Parse("2019-06-24"), CreatedById = systemUser, ModifiedOn = DateTime.Parse("2019-06-24"), ModifiedById = systemUser, Name = System.Enum.GetName(typeof(LoanStageEnum), LoanStageEnum.Completion), Description = GetDescription(LoanStageEnum.Completion), });
        }

        private static string GetDescription(LoanStageEnum loanStage)
        {
            var memInfo = typeof(LoanStageEnum).GetMember(typeof(LoanStageEnum).GetEnumName(loanStage));
            var descriptionAttribute = memInfo[0]
                .GetCustomAttributes(typeof(DescriptionAttribute), false)
                .FirstOrDefault() as DescriptionAttribute;

            if (descriptionAttribute != null)
            {
                return descriptionAttribute.Description;
            }

            return string.Empty;
        }
    }
}
