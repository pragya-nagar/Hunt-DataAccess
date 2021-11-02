using System;
using System.Collections.Generic;
using System.Text;

namespace Synergy.DataAccess.Entities.OpportunityEntities
{
    public abstract class OpportunityMonthlyPrepayBase : BaseAudit<int>
    {
        public int MonthlyPrepay { get; set; }
    }
}
