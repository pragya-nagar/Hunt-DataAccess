using System;

namespace Synergy.DataAccess.Entities.OpportunityEntities
{
    public class OpportunityProperty : OpportunityPropertyBase, IAuditEntity<Guid>, IEntity
    {
        public Opportunity Opportunity { get; set; }

        public Property Property { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
