namespace Synergy.DataAccess.Entities
{
    public class UnderwritingTask : Task
    {
        public UnderwritingWorkflow Workflow { get; set; }

        public UnderwritingTaskDefinition TaskDefinition { get; set; }
    }
}