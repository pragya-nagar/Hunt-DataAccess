using System;

namespace Synergy.DataAccess.Entities
{
    public abstract class UserPermissionBase : BaseAudit<Guid>
    {
        public Guid UserId { get; set; }

        public int PermissionId { get; set; }
    }

    public class UserPermission : UserPermissionBase, IEntity
    {
        public User User { get; set; }

        public Permission Permission { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
