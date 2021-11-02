using System;

namespace Synergy.DataAccess.Entities
{
    public class EventDecisionLevelPropertyProfileBase : BaseAudit<Guid>
    {
        public Guid PropertyProfileId { get; set; }

        public Guid EventDecisionLevelId { get; set; }

        public Guid EventId { get; set; }

        public int Order { get; set; }
    }

    public class EventDecisionLevelPropertyProfile : EventDecisionLevelPropertyProfileBase, IAuditEntity<Guid>, IEntity
    {
        public EventDecisionLevel EventDecisionLevel { get; set; }

        public PropertyProfile PropertyProfile { get; set; }

        public Event Event { get; set; }

        #region IAuditEntity<int> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
