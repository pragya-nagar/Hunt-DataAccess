using System;

namespace Synergy.DataAccess.Entities
{
    public abstract class DepartmentRoleBase : BaseAudit<Guid>
    {
        public Guid RoleId { get; set; }

        public int DepartmentId { get; set; }

        public bool IsManager { get; set; }
    }

    public class DepartmentRole : DepartmentRoleBase, IEntity, IAuditEntity<Guid>
    {
        public Role Role { get; set; }

        public Department Department { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
