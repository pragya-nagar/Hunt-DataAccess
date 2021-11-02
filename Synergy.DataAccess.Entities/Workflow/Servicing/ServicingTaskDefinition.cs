using System.Collections.Generic;

namespace Synergy.DataAccess.Entities
{
    public class ServicingTaskDefinition : TaskDefinition
    {
        public IEnumerable<ServicingTask> Tasks { get; set; }

        public IEnumerable<ServicingWorkflowTaskDefinition> Workflows { get; set; }
    }
}
