using System.ComponentModel;

namespace Synergy.DataAccess.Enum.Processing
{
    public enum LoanPropertyType
    {
        [Description("Residential – Owner Occupied")]
        ResidentialOwnerOccupied = 1,
        [Description("Residential – Non-Owner Occupied")]
        ResidentialNonOwnerOccupied,
        [Description("Commercial – Individually Owned")]
        CommercialIndividuallyOwned,
        [Description("Commercial – Entity Owned")]
        CommercialEntityOwned,
        [Description("Commercial - Land")]
        CommercialLand,
    }
}
