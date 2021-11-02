using System;
using System.Collections.Generic;

namespace Synergy.DataAccess.Entities
{
    public abstract class CampaignBase : BaseAudit<Guid>
    {
        public DateTime? TargetDate { get; set; }

        public DateTime? CreateDate { get; set; }

        public string CampaignName { get; set; }

        public string Description { get; set; }

        public string Note { get; set; }

        public int CampaignTypeId { get; set; }

        public int? CampaignSubTypeId { get; set; }

        public Guid AssignedUserId { get; set; }

        public int StateId { get; set; }

        public int? TotalRecords { get; set; }

        public decimal? TotalAmountRecords { get; set; }
    }

    public class Campaign : CampaignBase, IAuditEntity<Guid>, IEntity
    {
        public CampaignType CampaignType { get; set; }

        public CampaignType CampaignSubType { get; set; }

        public User AssignedUser { get; set; }

        public State State { get; set; }

        public IEnumerable<CampaignLead> CampaignLeads { get; set; }

        public IEnumerable<CampaignCounty> CampaignCounty { get; set; }

        public IEnumerable<CampaignRuleCampaign> CampaignRuleCampaign { get; set; }

        #region IAuditEntity<Guid> implementation

        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
