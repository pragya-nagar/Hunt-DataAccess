using System;

namespace Synergy.DataAccess.Entities.OpportunityEntities
{
    public abstract class OpportunityPropertyBase : BaseAudit<Guid>
    {
        public Guid PropertyId { get; set; }

        public Guid OpportunityId { get; set; }
    }
}
