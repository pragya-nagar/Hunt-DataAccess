using System.Collections.Generic;

namespace Synergy.DataAccess.Entities
{
    public class UnderwritingTaskDefinition : TaskDefinition
    {
        public IEnumerable<UnderwritingTask> Tasks { get; set; }

        public IEnumerable<UnderwritingWorkflowTaskDefinition> Workflows { get; set; }
    }
}
