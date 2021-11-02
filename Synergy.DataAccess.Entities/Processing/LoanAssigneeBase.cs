using System;

namespace Synergy.DataAccess.Entities.Processing
{
    public class LoanAssigneeBase : BaseAudit<Guid>
    {
        public Guid LoanId { get; set; }

        public Guid UserId { get; set; }
    }
}
