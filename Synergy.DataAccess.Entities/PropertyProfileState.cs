using System;

namespace Synergy.DataAccess.Entities
{
    public class PropertyProfileStateBase : BaseAudit<Guid>
    {
        public Guid PropertyProfileId { get; set; }

        public int StateId { get; set; }
    }

    public class PropertyProfileState : PropertyProfileStateBase, IAuditEntity<Guid>, IEntity
    {
        public PropertyProfile PropertyProfile { get; set; }

        public State State { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}