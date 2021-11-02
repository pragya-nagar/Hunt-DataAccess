using System;

namespace Synergy.DataAccess.Entities
{
    public class PropertyProfileRulePropertyProfileBase : BaseAudit<Guid>
    {
        public Guid PropertyProfileRuleId { get; set; }

        public Guid PropertyProfileId { get; set; }
    }

    public class PropertyProfileRulePropertyProfile : PropertyProfileRulePropertyProfileBase, IAuditEntity<Guid>, IEntity
    {
        public PropertyProfile PropertyProfile { get; set; }

        public PropertyProfileRule PropertyProfileRule { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
