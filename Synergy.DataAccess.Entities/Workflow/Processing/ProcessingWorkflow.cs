using System;
using System.Collections.Generic;
using Synergy.DataAccess.Entities.Processing;

namespace Synergy.DataAccess.Entities
{
    public class ProcessingWorkflow : Workflow
    {
        public Guid LoanId { get; set; }

        public Loan Loan { get; set; }

        public ProcessingWorkflowDefinition WorkflowDefinition { get; set; }

        public IEnumerable<ProcessingTask> Tasks { get; set; }
    }
}
