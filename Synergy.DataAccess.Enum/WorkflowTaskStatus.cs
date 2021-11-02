using System.ComponentModel;

namespace Synergy.DataAccess.Enum
{
    public enum WorkflowTaskStatus
    {
        [Description("None")]
        None = 0,
        [Description("In Progress")]
        InProgress,
        [Description("Completed")]
        Completed,
        [Description("Overdue")]
        Overdue,
    }
}