using System.ComponentModel;

namespace Synergy.DataAccess.Enum
{
    public enum CollectingEntityType
    {
        [Description("County")]
        County = 1,
        [Description("City")]
        City,
        [Description("ISD")]
        ISD,
        [Description("Other")]
        Other,
    }
}
