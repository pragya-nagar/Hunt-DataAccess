using System;
using System.Collections.Generic;

namespace Synergy.DataAccess.Entities
{
    public abstract class RoleBase : BaseAudit<Guid>
    {
        public string Name { get; set; }

        public bool IsActive { get; set; }
    }

    public class Role : RoleBase, IAuditEntity<Guid>, IEntity
    {
        public List<RolePermission> Permisions { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
