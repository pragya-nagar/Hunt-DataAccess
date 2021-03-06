using System;
using System.Collections.Generic;
using System.Text;

namespace Synergy.DataAccess.Entities.OpportunityEntities
{
   public class OpportunityMonthlyPrepay : OpportunityMonthlyPrepayBase, IAuditEntity<int>, IEntity
    {
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
    }
}
