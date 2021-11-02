using System;
using System.Collections.Generic;

namespace Synergy.DataAccess.Entities
{
    public abstract class UnderwritingWorkflowTaskDefinitionBase : BaseAudit<Guid>
    {
        public Guid WorkflowDefinitionId { get; set; }

        public Guid TaskDefinitionId { get; set; }

        public int Order { get; set; }

        public int DependencyTypeId { get; set; }
    }

    public class UnderwritingWorkflowTaskDefinition : UnderwritingWorkflowTaskDefinitionBase, IAuditEntity<Guid>, IEntity
    {
        public UnderwritingWorkflowDefinition WorkflowDefinition { get; set; }

        public UnderwritingTaskDefinition TaskDefinition { get; set; }

        public IEnumerable<UnderwritingWorkflowTaskDependency> Dependencies { get; set; }

        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
    }
}
