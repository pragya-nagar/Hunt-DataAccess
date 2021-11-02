using System;

namespace Synergy.DataAccess.Entities
{
    public abstract class WorkflowBase : BaseAudit<Guid>
    {
        public Guid WorkflowDefinitionId { get; set; }
    }

    public abstract class Workflow : WorkflowBase, IAuditEntity<Guid>, IEntity
    {
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
    }
}
