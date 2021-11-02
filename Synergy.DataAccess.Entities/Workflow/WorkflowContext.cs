using System;

namespace Synergy.DataAccess.Entities
{
    public abstract class WorkflowContextBase : BaseAudit<Guid>
    {
        public Guid WorkflowId { get; set; }

        public string Context { get; set; }
    }

    public class WorkflowContext : WorkflowContextBase, IAuditEntity<Guid>, IEntity
    {
        public Workflow Workflow { get; set; }

        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
    }
}