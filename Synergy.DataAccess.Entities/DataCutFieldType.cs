using System.Collections.Generic;

namespace Synergy.DataAccess.Entities
{
    public abstract class DataCutFieldTypeBase : BaseAudit<int>
    {
        public string Name { get; set; }
    }

    public class DataCutFieldType : DataCutFieldTypeBase, IAuditEntity<int>, IEntity
    {
        public IEnumerable<DataCutLogicType> DataCutLogicTypes { get; set; }

        #region IAuditEntity<int> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
