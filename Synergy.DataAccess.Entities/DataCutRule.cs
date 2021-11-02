using System;
using System.Collections.Generic;

namespace Synergy.DataAccess.Entities
{
    public abstract class DataCutRuleBase : BaseAudit<Guid>
    {
        public string Name { get; set; }

        public int CountyId { get; set; }

        public int DataCutResultTypeId { get; set; }
    }

    public class DataCutRule : DataCutRuleBase, IAuditEntity<Guid>, IEntity
    {
        public DataCutResultType DataCutResultType { get; set; }

        public IEnumerable<DataCutRuleItem> DataCutRuleItems { get; set; }

        public County County { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}