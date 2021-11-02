using System;
using System.Collections.Generic;

namespace Synergy.DataAccess.Entities
{
    public abstract class ProcessingWorkflowTaskDefinitionBase : BaseAudit<Guid>
    {
        public Guid WorkflowDefinitionId { get; set; }

        public Guid TaskDefinitionId { get; set; }

        public int Order { get; set; }

        public int DependencyTypeId { get; set; }
    }

    public class ProcessingWorkflowTaskDefinition : ProcessingWorkflowTaskDefinitionBase, IAuditEntity<Guid>, IEntity
    {
        public ProcessingWorkflowDefinition WorkflowDefinition { get; set; }

        public ProcessingTaskDefinition TaskDefinition { get; set; }

        public IEnumerable<ProcessingWorkflowTaskDependency> Dependencies { get; set; }

        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
    }
}
