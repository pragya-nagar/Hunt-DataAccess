using System.ComponentModel;

namespace Synergy.DataAccess.Enum
{
    public enum FinalPaymentType
    {
        [Description("Wire")]
        Wire = 1,
        [Description("Certified Funds")]
        CertifiedFunds,
        [Description("Company Check")]
        CompanyCheck,
    }
}
