using System.Collections.Generic;

namespace Synergy.DataAccess.Entities
{
    public class ModuleBase : BaseAudit<int>
    {
        public string Name { get; set; }
    }

    public class Module : BaseAudit<int>, IAuditEntity<int>, IEntity
    {
        public ICollection<TemplateType> TemplateTypes { get; set; }

        public string Name { get; set; }

        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
    }
}