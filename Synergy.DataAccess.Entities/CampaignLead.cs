using System;

namespace Synergy.DataAccess.Entities
{
    public abstract class CampaignLeadBase : BaseAudit<Guid>
    {
        public Guid CampaignId { get; set; }

        public Guid LeadId { get; set; }
    }

    public class CampaignLead : CampaignLeadBase, IAuditEntity<Guid>, IEntity
    {
        public Campaign Campaign { get; set; }

        public Lead Lead { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
