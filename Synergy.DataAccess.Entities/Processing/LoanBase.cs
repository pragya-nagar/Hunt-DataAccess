using System;

namespace Synergy.DataAccess.Entities.Processing
{
    public class LoanBase : BaseAudit<Guid>
    {
        public int StageId { get; set; }

        public Guid? AssigneeId { get; set; }

        public Guid OfficerId { get; set; }

        public int? LoanTypeId { get; set; }

        public int LoanPropertyTypeId { get; set; }

        public string LoanNumber { get; set; }

        public decimal? AmountDue { get; set; }

        public decimal? TotalLoanAmount { get; set; }

        public decimal? LTV { get; set; }

        public DateTime? CloseDate { get; set; }

        public decimal? CloseProbability { get; set; }

        public decimal? ClosingCost { get; set; }

        public decimal? CurrentLoanBalance { get; set; }

        public decimal? ThirdPartyLoanBalance { get; set; }

        public decimal? InterestRate { get; set; }

        public int? Term { get; set; }

        public decimal? MonthlyPayment { get; set; }

        public decimal? LenderCredit { get; set; }

        public decimal? OriginationPercent { get; set; }
    }
}
