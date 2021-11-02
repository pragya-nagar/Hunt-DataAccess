using System;

namespace Synergy.DataAccess.Entities
{
    public abstract class CampaignRuleCampaignBase : BaseAudit<Guid>
    {
        public Guid CampaignId { get; set; }

        public Guid CampaignRuleId { get; set; }
    }

    public class CampaignRuleCampaign : CampaignRuleCampaignBase, IAuditEntity<Guid>, IEntity
    {
        public Campaign Campaign { get; set; }

        public CampaignRule CampaignRule { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
