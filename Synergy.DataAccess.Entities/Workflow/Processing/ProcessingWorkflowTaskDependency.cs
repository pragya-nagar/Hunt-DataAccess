using System;

namespace Synergy.DataAccess.Entities
{
    public abstract class ProcessingWorkflowTaskDependencyBase : BaseAudit<Guid>
    {
        public Guid DependentId { get; set; }

        public Guid DependencyId { get; set; }
    }

    public class ProcessingWorkflowTaskDependency : ProcessingWorkflowTaskDependencyBase, IAuditEntity<Guid>, IEntity
    {
        public ProcessingWorkflowTaskDefinition Dependent { get; set; }

        public ProcessingWorkflowTaskDefinition Dependency { get; set; }

        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
    }
}
