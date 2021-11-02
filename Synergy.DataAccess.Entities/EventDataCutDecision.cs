using System;

namespace Synergy.DataAccess.Entities
{
    public class EventDataCutDecisionBase : BaseAudit<Guid>
    {
        public Guid EventDataCutStrategyId { get; set; }

        public int DecisionTypeId { get; set; }

        public Guid DelinquencyId { get; set; }
    }

    public class EventDataCutDecision : EventDataCutDecisionBase, IAuditEntity<Guid>, IEntity
    {
        public EventDataCutStrategy EventDataCutStrategy { get; set; }

        public DecisionType DecisionType { get; set; }

        public Delinquency Delinquency { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
