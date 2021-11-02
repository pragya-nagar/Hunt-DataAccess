using System;

namespace Synergy.DataAccess.Entities
{
    public class DataCutRuleItemBase : BaseAudit<Guid>
    {
        public string Value { get; set; }

        public Guid DataCutRuleId { get; set; }

        public int DataCutLogicTypeId { get; set; }

        public int DataCutRuleFieldId { get; set; }
    }

    public class DataCutRuleItem : DataCutRuleItemBase, IAuditEntity<Guid>, IEntity
    {
        public DataCutRule DataCutRule { get; set; }

        public DataCutLogicType DataCutLogicType { get; set; }

        public DataCutRuleField DataCutRuleField { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
