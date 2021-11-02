using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class PropertyAttachmentMap : IEntityTypeConfiguration<PropertyAttachment>
    {
        public void Configure(EntityTypeBuilder<PropertyAttachment> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}
