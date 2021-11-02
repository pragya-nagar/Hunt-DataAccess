using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class PropertyNotesMap : IEntityTypeConfiguration<PropertyNotes>
    {
        public void Configure(EntityTypeBuilder<PropertyNotes> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}
