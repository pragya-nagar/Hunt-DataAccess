namespace Synergy.DataAccess.Entities
{
    public abstract class GeneralLandUseCodeBase : BaseAudit<int>
    {
        public string Name { get; set; }
    }

    public class GeneralLandUseCode : GeneralLandUseCodeBase, IAuditEntity<int>, IEntity
    {
        #region IAuditEntity<int> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
