using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping.MailMerge
{
    public class TemplateFileMap : IEntityTypeConfiguration<TemplateFile>
    {
        public void Configure(EntityTypeBuilder<TemplateFile> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.TemplateType).WithMany(x => x.TemplateFiles).HasForeignKey(x => x.TemplateTypeId);
            builder.HasOne(x => x.State).WithMany().HasForeignKey(x => x.StateId);

            builder.HasMany(x => x.Counties).WithOne(x => x.TemplateFile).HasForeignKey(x => x.TemplateFileId);
        }
    }
}