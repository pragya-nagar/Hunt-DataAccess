namespace Synergy.DataAccess.Entities.OpportunityEntities
{
    public class OpportunityStage : OpportunityStageBase, IAuditEntity<int>, IEntity
    {
        #region IAuditEntity<int> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
