using System.ComponentModel;

namespace Synergy.DataAccess.Enum
{
    public enum DecisionType
    {
        [Description("Reject")]
        Reject = 1,
        [Description("Approve")]
        Approve,
        [Description("Auto Reject")]
        AutoReject,
        [Description("Auto Approve")]
        AutoApprove,
        [Description("Manual Review")]
        ManualReview,
        [Description("Research")]
        Research,
    }
}
