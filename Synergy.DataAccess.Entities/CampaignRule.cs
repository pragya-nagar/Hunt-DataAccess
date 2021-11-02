using System;
using System.Collections.Generic;

namespace Synergy.DataAccess.Entities
{
    public abstract class CampaignRuleBase : BaseAudit<Guid>
    {
        public string Name { get; set; }
    }

    public class CampaignRule : CampaignRuleBase, IAuditEntity<Guid>, IEntity
    {
        public IEnumerable<CampaignRuleItem> CampaignRuleItems { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
