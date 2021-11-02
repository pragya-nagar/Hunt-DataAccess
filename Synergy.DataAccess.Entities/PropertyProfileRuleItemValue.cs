using System;

namespace Synergy.DataAccess.Entities
{
    public class PropertyProfileRuleItemValueBase : BaseAudit<Guid>
    {
        public string Value { get; set; }

        public Guid PropertyProfileRuleItemId { get; set; }
    }

    public class PropertyProfileRuleItemValue : PropertyProfileRuleItemValueBase, IAuditEntity<Guid>, IEntity
    {
        public PropertyProfileRuleItem PropertyProfileRuleItem { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
