using System;

namespace Synergy.DataAccess.Entities
{
    public class CollectingEntityBase : BaseAudit<Guid>
    {
        public decimal AmountDue { get; set; }

        public Guid DelinquencyId { get; set; }

        public int CollectingEntityTypeId { get; set; }
    }

    public class CollectingEntity : CollectingEntityBase, IAuditEntity<Guid>, IEntity
    {
        public Delinquency Delinquency { get; set; }

        public CollectingEntityType CollectingEntityType { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
