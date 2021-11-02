using System;
using System.Collections.Generic;

namespace Synergy.DataAccess.Entities
{
    public abstract class EventDecisionLevelBase : BaseAudit<Guid>
    {
        public Guid EventId { get; set; }

        public int Order { get; set; }

        public string Name { get; set; }

        public bool IsFinal { get; set; }
    }

    public class EventDecisionLevel : EventDecisionLevelBase, IAuditEntity<Guid>, IEntity
    {
        public Event Event { get; set; }

        public List<EventDecisionLevelUser> EventDecisionLevelUser { get; set; }

        public List<Decision> Decisions { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
