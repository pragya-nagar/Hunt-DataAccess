using System.Collections.Generic;

namespace Synergy.DataAccess.Entities
{
    public abstract class PropertyDisplayStrategyBase : BaseAudit<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }

    public class PropertyDisplayStrategy : PropertyDisplayStrategyBase, IAuditEntity<int>, IEntity
    {
        public IEnumerable<DelinquencyPropertyDisplayStrategy> DelinquencyPropertyDisplayStrategy { get; set; }

        #region IAuditEntity<int> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
