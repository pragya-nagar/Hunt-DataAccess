namespace Synergy.DataAccess.Entities
{
    public class PropertyProfileRuleFieldBase : BaseAudit<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int PropertyProfileFieldTypeId { get; set; }
    }

    public class PropertyProfileRuleField : PropertyProfileRuleFieldBase, IAuditEntity<int>, IEntity
    {
        public PropertyProfileFieldType PropertyProfileFieldType { get; set; }

        #region IAuditEntity<int> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
