using System;
using System.Collections.Generic;

namespace Synergy.DataAccess.Entities
{
    public class PropertyProfileBase : BaseAudit<Guid>
    {
        public string Name { get; set; }

        public bool IsActive { get; set; }
    }

    public class PropertyProfile : PropertyProfileBase, IAuditEntity<Guid>, IEntity
    {
        public IEnumerable<PropertyProfileState> PropertyProfileStates { get; set; }

        public IEnumerable<PropertyProfileRulePropertyProfile> PropertyProfileRulePropertyProfiles { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
