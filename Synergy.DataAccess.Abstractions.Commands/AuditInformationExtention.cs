using System;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Abstractions.Commands
{
    public static class AuditInformationExtention
    {
        public static T OnCreateAudit<T>(this T entity, Guid userId)
            where T : IAuditEntity
        {
            entity.CreatedById = userId;
            entity.CreatedOn = DateTime.Now;
            entity.OnModifyAudit(userId);

            return entity;
        }

        public static T OnModifyAudit<T>(this T entity, Guid userId)
            where T : IAuditEntity
        {
            entity.ModifiedById = userId;
            entity.ModifiedOn = DateTime.Now;

            return entity;
        }

        public static T OnDeleteAudit<T>(this T entity, Guid userId)
            where T : IAuditEntity
        {
            entity.DeletedOn = DateTime.Now;
            entity.OnModifyAudit(userId);

            return entity;
        }
    }
}
