using System;

namespace Synergy.DataAccess.Entities.Processing
{
    public class LoanPropertyBase : BaseAudit<Guid>
    {
        public Guid LoanId { get; set; }

        public Guid PropertyId { get; set; }
    }
}
