using System;
using System.Collections.Generic;
using Synergy.DataAccess.Entities.OpportunityEntities;

namespace Synergy.DataAccess.Entities
{
    public abstract class ContactBase : BaseAudit<Guid>
    {
        public Guid LeadId { get; set; }

        public int ContactTypeId { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Title { get; set; }

        public string CellPhone { get; set; }

        public string OfficePhone { get; set; }

        public string Email { get; set; }

        public string MailingAddress1 { get; set; }

        public string MailingAddress2 { get; set; }

        public string MailingAddress3 { get; set; }

        public string MailingCity { get; set; }

        public int? MailingStateId { get; set; }

        public string MailingZipCode { get; set; }
    }

    public class Contact : ContactBase, IAuditEntity<Guid>, IEntity
    {
        public Lead Lead { get; set; }

        public ContactType ContactType { get; set; }

        public State MailingState { get; set; }

        public IEnumerable<OpportunityContact> OpportunityContacts { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
