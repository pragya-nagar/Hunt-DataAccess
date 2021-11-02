using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Synergy.Common;
using Synergy.DataAccess.Entities.OpportunityEntities;

namespace Synergy.DataAccess.Context.Mapping
{
    internal class OpportunityStageMap : IEntityTypeConfiguration<OpportunityStage>
    {
        public void Configure(EntityTypeBuilder<OpportunityStage> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasData(
               new OpportunityStage { Id = 1, Name = "InitialContact", Description = "Initial Contact", CreatedById = Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-19"), ModifiedById = Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-19") },
               new OpportunityStage { Id = 2, Name = "VerifiedProspect", Description = "Verified Prospect", CreatedById = Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-11"), ModifiedById = Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-11") },
               new OpportunityStage { Id = 3, Name = "FileStarted", Description = "File Started", CreatedById = Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-11"), ModifiedById = Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-11") });
        }
    }
}
