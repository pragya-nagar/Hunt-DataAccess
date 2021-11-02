using System.Collections.Generic;

namespace Synergy.DataAccess.Entities
{
    public class ServicingWorkflowDefinition : WorkflowDefinition
    {
        public IEnumerable<ServicingWorkflowTaskDefinition> Tasks { get; set; }
    }
}
