using System.ComponentModel;

namespace Synergy.DataAccess.Enum
{
    public enum OpportunityStage
    {
        [Description("Initial Contact")]
        InitialContact = 1,
        [Description("Verified Prospect")]
        VerifiedProspect,
        [Description("File Started")]
        FileStarted,
    }
}
