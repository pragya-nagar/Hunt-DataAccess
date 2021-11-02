using System;

namespace Synergy.DataAccess.Entities
{
    public abstract class RolePermissionBase : BaseAudit<int>
    {
        public Guid RoleId { get; set; }

        public int PermissionId { get; set; }
    }

    public class RolePermission : RolePermissionBase, IEntity, IAuditEntity<int>
    {
        public Role Role { get; set; }

        public Permission Permission { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
