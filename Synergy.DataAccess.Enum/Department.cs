using System.ComponentModel;

namespace Synergy.DataAccess.Enum
{
    public enum Department
    {
        [Description("Data")]
        Data = 1,
        [Description("Accounting")]
        Accounting,
        [Description("Management")]
        Management,
        [Description("Acquisition")]
        Acquisition,
        [Description("Asset Management")]
        AssetManagement,
        [Description("Underwriters")]
        Underwriters,
        [Description("Loan Officers")]
        LoanOfficers,
        [Description("Processing")]
        Processing,
    }
}