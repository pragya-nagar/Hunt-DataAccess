using System;
using System.Collections.Generic;

namespace Synergy.DataAccess.Entities.OpportunityEntities
{
    public class Opportunity : OpportunityBase, IAuditEntity<Guid>, IEntity
    {
        public Lead Lead { get; set; }

        public User User { get; set; }

        public OpportunityStage OpportunityStage { get; set; }

        public LoanType LoanType { get; set; }

        public Campaign Campaign { get; set; }

        public Contact Contact { get; set; }

        public OpportunityPropertyType OpportunityPropertyType { get; set; }

        public IEnumerable<OpportunityProperty> OpportunityProperties { get; set; }

        public IEnumerable<OpportunityContact> OpportunityContacts { get; set; }

        public IEnumerable<OpportunityBorrower> OpportunityBorrowers { get; set; }

        public IEnumerable<OpportunityCommercialBorrower> OpportunityCommercialBorrowers { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
