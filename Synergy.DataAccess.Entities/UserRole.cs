using System;

namespace Synergy.DataAccess.Entities
{
    public abstract class UserRoleBase : BaseAudit<Guid>
    {
        public Guid UserId { get; set; }

        public Guid RoleId { get; set; }
    }

    public class UserRole : UserRoleBase, IEntity, IAuditEntity<Guid>
    {
        public User User { get; set; }

        public Role Role { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
