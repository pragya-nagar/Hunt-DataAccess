namespace Synergy.DataAccess.Entities.OpportunityEntities
{
    public class OpportunityPropertyType : OpportunityPropertyTypeBase, IAuditEntity<int>, IEntity
    {
        #region IAuditEntity<int> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
