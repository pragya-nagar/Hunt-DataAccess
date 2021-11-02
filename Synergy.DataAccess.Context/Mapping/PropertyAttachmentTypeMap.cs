using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Synergy.DataAccess.Entities;
using Synergy.DataAccess.Entities.OpportunityEntities;

namespace Synergy.DataAccess.Context.Mapping
{
    public partial class PropertyAttachmentTypeMap : IEntityTypeConfiguration<PropertyAttachmentType>
    {
        public void Configure(EntityTypeBuilder<PropertyAttachmentType> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasData(
               new OpportunityStage { Id = (int)Enum.PropertyAttachmentType.Aerial, Name = Enum.PropertyAttachmentType.Aerial.ToString(), Description = "Aerial", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-01-21"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-01-21") },
               new OpportunityStage { Id = (int)Enum.PropertyAttachmentType.Attachment, Name = Enum.PropertyAttachmentType.Attachment.ToString(), Description = "Attachment", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-01-21"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-01-21") },
               new OpportunityStage { Id = (int)Enum.PropertyAttachmentType.PropertyImage, Name = Enum.PropertyAttachmentType.PropertyImage.ToString(), Description = "Property Image", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-01-21"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-01-21") });
        }
    }
}
