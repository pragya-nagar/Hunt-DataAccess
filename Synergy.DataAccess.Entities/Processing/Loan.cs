using System;
using System.Collections.Generic;

namespace Synergy.DataAccess.Entities.Processing
{
    public class Loan : LoanBase, IAuditEntity<Guid>, IEntity
    {
        public LoanStage Stage { get; set; }

        public IEnumerable<LoanAssignee> Assignees { get; set; }

        public User Officer { get; set; }

        public LoanType LoanType { get; set; }

        public LoanPropertyType LoanPropertyType { get; set; }

        public EntityBorrower EntityBorrower { get; set; }

        public IEnumerable<Borrower> Borrowers { get; set; }

        public IEnumerable<LoanProperty> LoanProperties { get; set; }

        #region IAuditEntity<Guid> implementation

        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
