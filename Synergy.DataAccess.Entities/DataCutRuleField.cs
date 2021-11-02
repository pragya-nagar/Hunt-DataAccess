namespace Synergy.DataAccess.Entities
{
    public abstract class DataCutRuleFieldBase : BaseAudit<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int DataCutFieldTypeId { get; set; }
    }

    public class DataCutRuleField : DataCutRuleFieldBase, IAuditEntity<int>, IEntity
    {
        public DataCutFieldType DataCutFieldType { get; set; }

        #region IAuditEntity<int> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
