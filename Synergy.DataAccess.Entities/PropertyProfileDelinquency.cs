using System;

namespace Synergy.DataAccess.Entities
{
    public abstract class PropertyProfileDelinquencyBase : BaseAudit<Guid>
    {
        public Guid DelinquencyId { get; set; }

        public Guid PropertyProfileId { get; set; }
    }

    public class PropertyProfileDelinquency : PropertyProfileDelinquencyBase, IAuditEntity<Guid>, IEntity
    {
        public Delinquency Delinquency { get; set; }

        public PropertyProfile PropertyProfile { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
