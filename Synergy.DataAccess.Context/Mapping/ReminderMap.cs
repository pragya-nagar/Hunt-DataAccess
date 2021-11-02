using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class ReminderMap : IEntityTypeConfiguration<Reminder>
    {
        public void Configure(EntityTypeBuilder<Reminder> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}
