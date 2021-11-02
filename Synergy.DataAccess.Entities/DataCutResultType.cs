namespace Synergy.DataAccess.Entities
{
    public abstract class DataCutResultTypeBase : BaseAudit<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }

    public class DataCutResultType : DataCutResultTypeBase, IAuditEntity<int>, IEntity
    {
        #region IAuditEntity<int> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
