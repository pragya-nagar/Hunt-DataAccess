using System.Collections.Generic;

namespace Synergy.DataAccess.Entities
{
    public class ProcessingWorkflowDefinition : WorkflowDefinition
    {
        public IEnumerable<ProcessingWorkflowTaskDefinition> Tasks { get; set; }

        public IEnumerable<ProcessingWorkflowDefinitionState> States { get; set; }
    }
}
