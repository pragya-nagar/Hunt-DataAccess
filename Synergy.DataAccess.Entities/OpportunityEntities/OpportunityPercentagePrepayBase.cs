using System;
using System.Collections.Generic;
using System.Text;

namespace Synergy.DataAccess.Entities.OpportunityEntities
{
    public abstract class OpportunityPercentagePrepayBase : BaseAudit<int>
    {
        public decimal PercentagePrepay { get; set; }
    }
}
