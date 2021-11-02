using System;

namespace Synergy.DataAccess.Entities
{
    public abstract class ServicingWorkflowTaskDependencyBase : BaseAudit<Guid>
    {
        public Guid DependentId { get; set; }

        public Guid DependencyId { get; set; }
    }

    public class ServicingWorkflowTaskDependency : ServicingWorkflowTaskDependencyBase, IAuditEntity<Guid>, IEntity
    {
        public ServicingWorkflowTaskDefinition Dependent { get; set; }

        public ServicingWorkflowTaskDefinition Dependency { get; set; }

        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
    }
}
