using System;
using System.Collections.Generic;

namespace Synergy.DataAccess.Entities
{
    public class PropertyProfileRuleItemBase : BaseAudit<Guid>
    {
        public Guid PropertyProfileRuleId { get; set; }

        public int PropertyProfileLogicTypeId { get; set; }

        public int PropertyProfileRuleFieldId { get; set; }
    }

    public class PropertyProfileRuleItem : PropertyProfileRuleItemBase, IAuditEntity<Guid>, IEntity
    {
        public PropertyProfileRule PropertyProfileRule { get; set; }

        public PropertyProfileLogicType PropertyProfileLogicType { get; set; }

        public PropertyProfileRuleField PropertyProfileRuleField { get; set; }

        public IEnumerable<PropertyProfileRuleItemValue> PropertyProfileRuleItemValues { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
