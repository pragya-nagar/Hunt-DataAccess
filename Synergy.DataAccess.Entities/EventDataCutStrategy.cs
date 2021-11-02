using System;
using System.Collections.Generic;

namespace Synergy.DataAccess.Entities
{
    public abstract class EventDataCutStrategyBase : BaseAudit<Guid>
    {
        public Guid EventId { get; set; }

        public bool IsActive { get; set; }
    }

    public class EventDataCutStrategy : EventDataCutStrategyBase, IAuditEntity<Guid>, IEntity
    {
        public Event Event { get; set; }

        public List<EventDataCutRule> EventDataCutRules { get; set; }

        public List<EventDataCutDecision> EventDataCutDecisions { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
