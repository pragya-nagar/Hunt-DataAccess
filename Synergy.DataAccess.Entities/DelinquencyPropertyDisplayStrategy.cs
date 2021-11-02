using System;

namespace Synergy.DataAccess.Entities
{
    public abstract class DelinquencyPropertyDisplayStrategyBase : BaseAudit<Guid>
    {
        public Guid DelinquencyId { get; set; }

        public int PropertyDisplayStrategyId { get; set; }
    }

    public class DelinquencyPropertyDisplayStrategy : DelinquencyPropertyDisplayStrategyBase, IAuditEntity<Guid>, IEntity
    {
        public Delinquency Delinquency { get; set; }

        public PropertyDisplayStrategy PropertyDisplayStrategy { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
