using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;
using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public abstract class AuditMap<TEntity, T> : IEntityTypeConfiguration<TEntity>
            where TEntity : BaseAudit<T>, IAuditModelFields
    {
        public abstract void AdditionalMapping(EntityTypeBuilder<TEntity> builder);

        public void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(c => new { c.Id, c.InsertedOn });
            AdditionalMapping(builder);
        }
    }
}
