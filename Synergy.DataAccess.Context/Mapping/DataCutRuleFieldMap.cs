using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class DataCutRuleFieldMap : IEntityTypeConfiguration<DataCutRuleField>
    {
        public void Configure(EntityTypeBuilder<DataCutRuleField> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasData(
                new DataCutRuleField { Id = 1, Name = "AccountName", Description = "Account Name", DataCutFieldTypeId = 1, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-18"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-18") },
                new DataCutRuleField { Id = 2, Name = "PropertyAddress", Description = "Property Address", DataCutFieldTypeId = 1, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-18"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-18") },
                new DataCutRuleField { Id = 3, Name = "PropertyZipCode", Description = "Property Zip Code", DataCutFieldTypeId = 1, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-18"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-18") },
                new DataCutRuleField { Id = 4, Name = "LandUseCode", Description = "Land Use Code", DataCutFieldTypeId = 1, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-18"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-18") },
                new DataCutRuleField { Id = 5, Name = "GeneralLandUseCode", Description = "General Land Use Code", DataCutFieldTypeId = 1, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-18"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-18") },
                new DataCutRuleField { Id = 6, Name = "LandValue", Description = "Land Value", DataCutFieldTypeId = 2, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-18"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-18") },
                new DataCutRuleField { Id = 7, Name = "ImprovementValue", Description = "Improvement Value", DataCutFieldTypeId = 2, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-18"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-18") },
                new DataCutRuleField { Id = 8, Name = "AppraisedValue", Description = "Appraised Value", DataCutFieldTypeId = 2, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-18"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-18") },
                new DataCutRuleField { Id = 9, Name = "AmountDue", Description = "Amount Due", DataCutFieldTypeId = 2, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-18"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-18") },
                new DataCutRuleField { Id = 10, Name = "OpenLiens", Description = "Open Liens", DataCutFieldTypeId = 2, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-18"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-18") },
                new DataCutRuleField { Id = 11, Name = "ClosedLiens", Description = "Closed Liens", DataCutFieldTypeId = 2, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-18"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-18") },
                new DataCutRuleField { Id = 12, Name = "LTVPercent", Description = "LTV%", DataCutFieldTypeId = 2, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-18"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-18") },
                new DataCutRuleField { Id = 14, Name = "RULTVPercent", Description = "RU LTV%", DataCutFieldTypeId = 2, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-18"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-18") },
                new DataCutRuleField { Id = 15, Name = "TaxRatioPercent", Description = "Tax Ratio%", DataCutFieldTypeId = 2, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-18"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-18") });
        }
    }
}
