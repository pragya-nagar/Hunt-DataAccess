using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class PropertyChatMap : IEntityTypeConfiguration<PropertyChat>
    {
        public void Configure(EntityTypeBuilder<PropertyChat> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}
