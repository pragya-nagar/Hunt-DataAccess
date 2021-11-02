using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class DelinquencyMap : IEntityTypeConfiguration<Delinquency>
    {
        public void Configure(EntityTypeBuilder<Delinquency> modelBuilder)
        {
            modelBuilder.HasKey(x => x.Id);
            modelBuilder.HasIndex(c => new { c.EventId, c.PropertyId, c.DelinquencyTaxYear }).IsUnique();
            modelBuilder.Property(b => b.IsLoan).HasDefaultValue(false);
        }
    }
}
