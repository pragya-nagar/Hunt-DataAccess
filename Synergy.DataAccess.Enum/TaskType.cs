using System.ComponentModel;

namespace Synergy.DataAccess.Enum
{
    public enum TaskType
    {
        [Description("Create Event")]
        CreateEvent = 1,
        [Description("Enter Sale Info")]
        EnterSaleInfo,
        [Description("Upload Delinquent Listing")]
        UploadDelinquentListing,
        [Description("Registration")]
        Registration,
        [Description("Deposit")]
        Deposit,
        [Description("Run Data Macro")]
        RunDataMacro,
        [Description("Supplemental Data")]
        SupplementalData,
        [Description("Import Data")]
        ImportData,
        [Description("Data Filters")]
        DataFilters,
        [Description("Pre Lim List (Mail Merge)")]
        PreLimList,
        [Description("Pre-Sale Letters")]
        PreSaleLetters,
        [Description("Order Inspections")]
        OrderInspections,
        [Description("Import Inspections")]
        ImportInspections,
        [Description("Assign Reviewer")]
        AssignReviewer,
        [Description("First Round Review")]
        FirstRoundReview,
        [Description("Second Round Review")]
        SecondRoundReview,
        [Description("Final Review")]
        FinalReview,
        [Description("Lock Event")]
        LockEvent,
        [Description("Prepare Bid File")]
        PrepareBidFile,
        [Description("Funding")]
        Funding,
        [Description("Import Results")]
        ImportResults,
        [Description("Create Workset")]
        CreateWorkset,
        [Description("Certificates (Mail Merge)")]
        Certificates,
        [Description("Post-Sale Letters (Mail Merge)")]
        PostSaleLetters,
    }
}
