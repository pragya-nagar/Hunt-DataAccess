using System;

namespace Synergy.DataAccess.Entities
{
    public abstract class WorkflowDefinitionBase : BaseAudit<Guid>
    {
        public string Name { get; set; }

        public bool IsActive { get; set; }

        public Guid? OriginalId { get; set; }
    }

    public abstract class WorkflowDefinition : WorkflowDefinitionBase, IAuditEntity<Guid>, IEntity
    {
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
    }
}
