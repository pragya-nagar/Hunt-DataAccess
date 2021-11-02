using System;
using System.Collections.Generic;

namespace Synergy.DataAccess.Entities
{
    public class UnderwritingWorkflow : Workflow
    {
        public Guid EventId { get; set; }

        public Event Event { get; set; }

        public UnderwritingWorkflowDefinition WorkflowDefinition { get; set; }

        public IEnumerable<UnderwritingTask> Tasks { get; set; }
    }
}
