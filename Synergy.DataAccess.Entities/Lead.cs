using System;
using System.Collections.Generic;

namespace Synergy.DataAccess.Entities
{
    public abstract class LeadBase : BaseAudit<Guid>
    {
        public string AccountName { get; set; }

        public string MailingAddress1 { get; set; }

        public string MailingAddress2 { get; set; }

        public string MailingAddress3 { get; set; }

        public string MailingCity { get; set; }

        public int? MailingStateId { get; set; }

        public string MailingZipCode { get; set; }

        public bool DoNotContact { get; set; }

        public decimal? TotalAmountDueProperties { get; set; }

        public decimal? AppraisedValueOfProperties { get; set; }

        // ETL related column
        public string LeadBK { get; set; }

        public int? LeadSourceId { get; set; }
    }

    public class Lead : LeadBase, IAuditEntity<Guid>, IEntity
    {
        public State MailingState { get; set; }

        public IEnumerable<Contact> Contacts { get; set; }

        public IEnumerable<CampaignLead> CampaignLeads { get; set; }

        public IEnumerable<Property> Properties { get; set; }

        public IEnumerable<LeadComment> Comments { get; set; }

        public LeadSourceType LeadSourceType { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
