using System;

namespace Synergy.DataAccess.Entities
{
    public abstract class CampaignRuleItemBase : BaseAudit<Guid>
    {
        public string Value { get; set; }

        public Guid CampaignRuleId { get; set; }

        public int CampaignLogicTypeId { get; set; }

        public int CampaignRuleFieldId { get; set; }
    }

    public class CampaignRuleItem : CampaignRuleItemBase, IAuditEntity<Guid>, IEntity
    {
        public CampaignRule CampaignRule { get; set; }

        public CampaignLogicType CampaignLogicType { get; set; }

        public CampaignRuleField CampaignRuleField { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
