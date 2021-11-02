using System;

namespace Synergy.DataAccess.Entities.OpportunityEntities
{
    public class OpportunityContact : OpportunityContactBase, IAuditEntity<Guid>, IEntity
    {
        public Opportunity Opportunity { get; set; }

        public Contact Contact { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
