using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class CampaignTypeMap : IEntityTypeConfiguration<CampaignType>
    {
        public void Configure(EntityTypeBuilder<CampaignType> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasData(
                new CampaignType { Id = 1, Name = "Mailer", Description = "Mailer", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-15"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-15") },
                new CampaignType { Id = 2, Name = "Outbound", Description = "Outbound", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-15"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-15") },
                new CampaignType { Id = 3, Name = "Email", Description = "Email", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-15"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-15") },
                new CampaignType { Id = 4, Name = "CommericalTrip", Description = "Commerical Trip", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-15"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-15") },
                new CampaignType { Id = 5, Name = "Digital", Description = "Digital", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-15"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-15") },

                // SubTypes
                // Commercial Trip
                new CampaignType { Id = 6, ParentTypeId = 4, Name = "DFWJan", Description = "DFW-Jan", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-15"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-15") },
                new CampaignType { Id = 7, ParentTypeId = 4, Name = "DFWFeb", Description = "DFW-Feb", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-15"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-15") },
                new CampaignType { Id = 8, ParentTypeId = 4, Name = "HOUAug", Description = "HOU-Aug", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-15"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-15") },
                new CampaignType { Id = 9, ParentTypeId = 4, Name = "HOUDec", Description = "HOU-Dec", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-15"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-15") },
                new CampaignType { Id = 10, ParentTypeId = 4, Name = "STXMar", Description = "STX-Mar", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-15"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-15") },
                new CampaignType { Id = 11, ParentTypeId = 4, Name = "STXJul", Description = "STX-Jul", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-15"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-15") },
                new CampaignType { Id = 12, ParentTypeId = 4, Name = "WTX", Description = "WTX", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-15"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-15") },
                new CampaignType { Id = 13, ParentTypeId = 4, Name = "ETX", Description = "ETX", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-15"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-15") },

                // Mailer
                new CampaignType { Id = 14, ParentTypeId = 1, Name = "FEB", Description = "FEB", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-15"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-15") },
                new CampaignType { Id = 15, ParentTypeId = 1, Name = "JUN", Description = "JUN", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-15"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-15") },
                new CampaignType { Id = 16, ParentTypeId = 1, Name = "SPECIAL", Description = "SPECIAL", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-15"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-15") },

                // Outbound
                new CampaignType { Id = 17, ParentTypeId = 2, Name = "CSRREFI", Description = "CSR-REFI", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-15"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-15") },
                new CampaignType { Id = 18, ParentTypeId = 2, Name = "HISTORICALLEADS", Description = "HISTORICAL LEADS", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-15"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-15") },
                new CampaignType { Id = 19, ParentTypeId = 2, Name = "DTR", Description = "DTR", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-15"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-15") },

                // Email
                new CampaignType { Id = 20, ParentTypeId = 3, Name = "CSR", Description = "CSR", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-15"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-15") },
                new CampaignType { Id = 21, ParentTypeId = 3, Name = "LOMAILMERGE", Description = "LO MAIL MERGE", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-15"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-15") },

                // Digital
                new CampaignType { Id = 22, ParentTypeId = 5, Name = "GooglePaid", Description = "Google Paid", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-15"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-15") },
                new CampaignType { Id = 23, ParentTypeId = 5, Name = "Display", Description = "Display", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-15"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-15") },
                new CampaignType { Id = 24, ParentTypeId = 5, Name = "LandingPage", Description = "Landing Page", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-15"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-15") });
        }
    }
}
