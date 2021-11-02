using System;

namespace Synergy.DataAccess.Entities.Processing
{
    public class LoanProperty : LoanPropertyBase, IAuditEntity<Guid>, IEntity
    {
        public Loan Loan { get; set; }

        public Property Property { get; set; }

        #region IAuditEntity<Guid> implementation

        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
