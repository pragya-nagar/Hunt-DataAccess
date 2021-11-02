using System;
using System.Collections.Generic;

namespace Synergy.DataAccess.Entities
{
    public class ServicingWorkflow : Workflow
    {
        public ServicingWorkflowDefinition WorkflowDefinition { get; set; }

        public IEnumerable<ServicingTask> Tasks { get; set; }
    }
}
