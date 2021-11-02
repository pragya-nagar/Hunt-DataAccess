using System.ComponentModel;

namespace Synergy.DataAccess.Enum
{
    public enum EventType
    {
        [Description("New")]
        New = 1,
        [Description("Sub")]
        Sub,
        [Description("Portfolio")]
        Portfolio,
        [Description("Public Sale")]
        PublicSale,
    }
}
