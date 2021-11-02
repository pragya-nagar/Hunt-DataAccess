using System;

namespace Synergy.DataAccess.Entities.Processing
{
    public class LoanAssignee : LoanAssigneeBase, IAuditEntity<Guid>, IEntity
    {
        public Loan Loan { get; set; }

        public User User { get; set; }

        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
    }
}