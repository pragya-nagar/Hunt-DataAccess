using System;

namespace Synergy.DataAccess.Entities
{
    public abstract class UnderwritingWorkflowTaskDependencyBase : BaseAudit<Guid>
    {
        public Guid DependentId { get; set; }

        public Guid DependencyId { get; set; }
    }

    public class UnderwritingWorkflowTaskDependency : UnderwritingWorkflowTaskDependencyBase, IAuditEntity<Guid>, IEntity
    {
        public UnderwritingWorkflowTaskDefinition Dependent { get; set; }

        public UnderwritingWorkflowTaskDefinition Dependency { get; set; }

        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
    }
}
