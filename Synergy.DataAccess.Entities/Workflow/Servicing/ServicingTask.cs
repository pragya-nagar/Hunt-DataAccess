namespace Synergy.DataAccess.Entities
{
    public class ServicingTask : Task
    {
        public ServicingWorkflow Workflow { get; set; }

        public ServicingTaskDefinition TaskDefinition { get; set; }
    }
}