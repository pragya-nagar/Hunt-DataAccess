using System.Collections.Generic;

namespace Synergy.DataAccess.Entities
{
    public abstract class PermissionBase : BaseAudit<int>
    {
        public string Action { get; set; }

        public string Description { get; set; }
    }

    public class Permission : PermissionBase, IAuditEntity<int>, IEntity
    {
        public List<Role> Roles { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
