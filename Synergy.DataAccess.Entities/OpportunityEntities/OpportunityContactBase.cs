using System;

namespace Synergy.DataAccess.Entities.OpportunityEntities
{
    public abstract class OpportunityContactBase : BaseAudit<Guid>
    {
        public Guid OpportunityId { get; set; }

        public Guid ContactId { get; set; }
    }
}
