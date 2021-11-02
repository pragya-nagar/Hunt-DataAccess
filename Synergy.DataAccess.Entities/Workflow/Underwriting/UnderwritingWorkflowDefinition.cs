using System.Collections.Generic;

namespace Synergy.DataAccess.Entities
{
    public class UnderwritingWorkflowDefinition : WorkflowDefinition
    {
        public IEnumerable<UnderwritingWorkflowTaskDefinition> Tasks { get; set; }

        public IEnumerable<UnderwritingWorkflowDefinitionState> States { get; set; }

        public IEnumerable<UnderwritingWorkflowDefinitionEventType> EventTypes { get; set; }
    }
}
