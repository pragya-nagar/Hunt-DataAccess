using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class CampaignRuleFieldMap : IEntityTypeConfiguration<CampaignRuleField>
    {
        public void Configure(EntityTypeBuilder<CampaignRuleField> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasData(
                new CampaignRuleField { Id = 1, Name = "AccountName", Description = "Account Name", CampaignFieldTypeId = 1, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-24"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-24") },
                new CampaignRuleField { Id = 2, Name = "County", Description = "County", CampaignFieldTypeId = 1, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-24"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-24") },
                new CampaignRuleField { Id = 3, Name = "GeneralLandUseCode", Description = "General Land Use Code (Residential or Commercial)", CampaignFieldTypeId = 1, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-24"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-24") },
                new CampaignRuleField { Id = 4, Name = "TotalAmountDue", Description = "Total Amount Due (of a single property)", CampaignFieldTypeId = 2, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-24"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-24") },
                new CampaignRuleField { Id = 5, Name = "TotalAmountDueProperties)", Description = "Total Amount Due (of all related properties)", CampaignFieldTypeId = 2, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-24"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-24") },
                new CampaignRuleField { Id = 6, Name = "LTV%", Description = "LTV % (LTV% = Total Tax Due / Appraised Value)", CampaignFieldTypeId = 2, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-24"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-24") },
                new CampaignRuleField { Id = 7, Name = "LTV%OfProperties", Description = "LTV% (of all related properties)", CampaignFieldTypeId = 2, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-24"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-24") },
                new CampaignRuleField { Id = 8, Name = "AppraisedValue", Description = "Appraised Value", CampaignFieldTypeId = 2, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-24"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-24") },
                new CampaignRuleField { Id = 9, Name = "AppraisedValueOfProperties) ", Description = "Appraised Value (of all related properties)", CampaignFieldTypeId = 2, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-24"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-24") },
                new CampaignRuleField { Id = 10, Name = "Over65/SurvivingSpouse", Description = "Over 65/Surviving Spouse", CampaignFieldTypeId = 3, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-24"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-24") },
                new CampaignRuleField { Id = 11, Name = "DisabilityExemption", Description = "Disability Exemption", CampaignFieldTypeId = 3, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-24"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-24") },
                new CampaignRuleField { Id = 12, Name = "Veteran", Description = "Veteran", CampaignFieldTypeId = 3, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-24"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-24") },
                new CampaignRuleField { Id = 13, Name = "DoNotContact", Description = "Do Not Contact", CampaignFieldTypeId = 3, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-24"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-24") });
        }
    }
}