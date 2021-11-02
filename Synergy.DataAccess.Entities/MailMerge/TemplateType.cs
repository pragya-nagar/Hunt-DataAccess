using System.Collections.Generic;

namespace Synergy.DataAccess.Entities
{
    public class TemplateTypeBase : BaseAudit<int>
    {
        public string Name { get; set; }

        public int GroupingType { get; set; }

        public int ModuleId { get; set; }
    }

    public class TemplateType : TemplateTypeBase, IAuditEntity<int>, IEntity
    {
        public Module Module { get; set; }

        public IEnumerable<TemplateFile> TemplateFiles { get; set; }

        #region IAuditEntity<int> implementation

        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }

        #endregion
    }
}