namespace Synergy.DataAccess.Entities
{
    public class ProcessingTask : Task
    {
        public ProcessingWorkflow Workflow { get; set; }

        public ProcessingTaskDefinition TaskDefinition { get; set; }
    }
}