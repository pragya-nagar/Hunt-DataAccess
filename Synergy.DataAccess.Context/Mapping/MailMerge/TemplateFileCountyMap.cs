using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.MailMerge;

namespace Synergy.DataAccess.Context.Mapping.MailMerge
{
    public class TemplateFileCountyMap : IEntityTypeConfiguration<TemplateFileCounty>
    {
        public void Configure(EntityTypeBuilder<TemplateFileCounty> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.TemplateFile).WithMany(x => x.Counties).HasForeignKey(x => x.TemplateFileId);
            builder.HasOne(x => x.County).WithMany().HasForeignKey(x => x.CountyId);

            builder.HasIndex(x => new { x.TemplateFileId, x.CountyId }).IsUnique();
        }
    }
}