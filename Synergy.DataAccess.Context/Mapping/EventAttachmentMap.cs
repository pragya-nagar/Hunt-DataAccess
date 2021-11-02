using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class EventAttachmentMap : IEntityTypeConfiguration<EventAttachment>
    {
        public void Configure(EntityTypeBuilder<EventAttachment> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}
