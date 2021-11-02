using System.ComponentModel;

namespace Synergy.DataAccess.Enum
{
    public enum LoanType
    {
        [Description("New")]
        New = 1,

        [Description("New Consolidation")]
        NewConsolidation,

        [Description("REFI")]
        Refi,

        [Description("REFI Consolidation")]
        RefiConsolidation,

        [Description("SYL")]
        Syl,

        [Description("SYL Consolidation")]
        SylConsolidation,
    }
}
