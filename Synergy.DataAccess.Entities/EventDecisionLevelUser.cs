using System;

namespace Synergy.DataAccess.Entities
{
    public abstract class EventDecisionLevelUserBase : BaseAudit<Guid>
    {
        public int AssigmentCount { get; set; }

        public Guid EventDecisionLevelId { get; set; }

        public Guid? EventDecisionLevelPropertyProfileId { get; set; }

        public Guid UserId { get; set; }
    }

    public class EventDecisionLevelUser : EventDecisionLevelUserBase, IAuditEntity<Guid>, IEntity
    {
        public EventDecisionLevel EventDecisionLevel { get; set; }

        public EventDecisionLevelPropertyProfile EventDecisionLevelPropertyProfile { get; set; }

        public User User { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
