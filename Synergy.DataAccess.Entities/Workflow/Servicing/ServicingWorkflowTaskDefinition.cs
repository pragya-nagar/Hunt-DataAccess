using System;
using System.Collections.Generic;

namespace Synergy.DataAccess.Entities
{
    public abstract class ServicingWorkflowTaskDefinitionBase : BaseAudit<Guid>
    {
        public Guid WorkflowDefinitionId { get; set; }

        public Guid TaskDefinitionId { get; set; }

        public int Order { get; set; }

        public int DependencyTypeId { get; set; }
    }

    public class ServicingWorkflowTaskDefinition : ServicingWorkflowTaskDefinitionBase, IAuditEntity<Guid>, IEntity
    {
        public ServicingWorkflowDefinition WorkflowDefinition { get; set; }

        public ServicingTaskDefinition TaskDefinition { get; set; }

        public IEnumerable<ServicingWorkflowTaskDependency> Dependencies { get; set; }

        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
    }
}
