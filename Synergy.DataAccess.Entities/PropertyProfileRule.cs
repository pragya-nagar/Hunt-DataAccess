using System;
using System.Collections.Generic;

namespace Synergy.DataAccess.Entities
{
    public class PropertyProfileRuleBase : BaseAudit<Guid>
    {
        public string Name { get; set; }
    }

    public class PropertyProfileRule : PropertyProfileRuleBase, IAuditEntity<Guid>, IEntity
    {
        public IEnumerable<PropertyProfileRuleItem> PropertyProfileRuleItems { get; set; }

        public IEnumerable<PropertyProfileRulePropertyProfile> PropertyProfileRulePropertyProfiles { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
