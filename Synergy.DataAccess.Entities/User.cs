using System;

namespace Synergy.DataAccess.Entities
{
    public abstract class UserBase : BaseAudit<Guid>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public bool IsActive { get; set; }
    }

    public class User : UserBase, IAuditEntity<Guid>, IEntity
    {
        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
