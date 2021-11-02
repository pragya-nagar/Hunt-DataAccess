using System;

namespace Synergy.DataAccess.Entities
{
    public abstract class EventDataCutRuleBase : BaseAudit<Guid>
    {
        public Guid EventDataCutStrategyId { get; set; }

        public Guid DataCutRuleId { get; set; }
    }

    public class EventDataCutRule : EventDataCutRuleBase, IAuditEntity<Guid>, IEntity
    {
        public EventDataCutStrategy EventDataCutStrategy { get; set; }

        public DataCutRule DataCutRule { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
