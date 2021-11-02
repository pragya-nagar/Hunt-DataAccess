using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Synergy.DataAccess.Enum.Processing
{
    public enum LoanStage
    {
        [Description("File Started")]
        FileStarted = 1,
        [Description("Disclosed")]
        Disclosed,
        [Description("Processing")]
        Processing,
        [Description("Underwriting")]
        Underwriting,
        [Description("Scheduled")]
        Scheduled,
        [Description("Docs Sent")]
        DocsSent,
        [Description("Funded")]
        Funded,
        [Description("Completion")]
        Completion,
    }
}
