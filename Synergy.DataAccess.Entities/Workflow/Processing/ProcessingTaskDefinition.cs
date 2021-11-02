using System.Collections.Generic;

namespace Synergy.DataAccess.Entities
{
    public class ProcessingTaskDefinition : TaskDefinition
    {
        public IEnumerable<ProcessingTask> Tasks { get; set; }

        public IEnumerable<ProcessingWorkflowTaskDefinition> Workflows { get; set; }
    }
}
