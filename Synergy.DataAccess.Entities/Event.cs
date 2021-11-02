using System;
using System.Collections.Generic;

namespace Synergy.DataAccess.Entities
{
    public abstract class EventBase : BaseAudit<Guid>
    {
        public string EventNumber { get; set; }

        public int CountyId { get; set; }

        public DateTime SaleDate { get; set; }

        public DateTime DueDate { get; set; }

        public string CurrentTask { get; set; }

        public string Progress { get; set; }

        public DateTime? FundingDate { get; set; }

        public DateTime? RegistrationDeadline { get; set; }

        public DateTime? DepositDeadline { get; set; }

        public decimal? DepositAmount { get; set; }

        public decimal? TreasurerFee { get; set; }

        public decimal? InterestRate { get; set; }

        public string AuctionAddress { get; set; }

        public DateTime? AuctionStartTime { get; set; }

        public string TreasurerName { get; set; }

        public string TreasurerEmail { get; set; }

        public decimal? EstimatedPurchaseAmount { get; set; }

        public decimal? EstimatedDepositAmount { get; set; }

        public decimal? RefundAmount { get; set; }

        public bool IsLocked { get; set; }

        public int StateId { get; set; }

        public int EventTypeId { get; set; }

        public int AuctionTypeId { get; set; }

        public int SaleDateStatusId { get; set; }

        public int? EventEntityId { get; set; }

        public int? FinalPaymentTypeId { get; set; }

        public Guid UserId { get; set; }

        public int? OriginalListCount { get; set; }

        public decimal? OriginalListAmount { get; set; }

        public bool IsFreezed { get; set; }

        public bool IsRejectReasonRequired { get; set; }
    }

    public class Event : EventBase, IAuditEntity<Guid>, IEntity
    {
        public County County { get; set; }

        public List<EventUser> EventUsers { get; set; }

        public State State { get; set; }

        public EventType EventType { get; set; }

        public AuctionType AuctionType { get; set; }

        public SaleDateStatus SaleDateStatus { get; set; }

        public EventEntity EventEntity { get; set; }

        public FinalPaymentType FinalPaymentType { get; set; }

        public User User { get; set; }

        public IEnumerable<Bid> Bids { get; set; }

        public IEnumerable<Delinquency> Delinquencies { get; set; }

        public IEnumerable<EventAttachment> EventAttachments { get; set; }

        public IEnumerable<EventDecisionLevel> EventDecisionLevels { get; set; }

        public IEnumerable<EventDataCutStrategy> EventDataCutStrategies { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}