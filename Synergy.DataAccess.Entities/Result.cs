using System;

namespace Synergy.DataAccess.Entities
{
    public abstract class ResultBase : BaseAudit<Guid>
    {
        public string BidNumber { get; set; }

        public string CertNo { get; set; }

        public decimal TaxAmount { get; set; }

        public decimal? Overbid { get; set; }

        public decimal? Premium { get; set; }

        public decimal InterestRate { get; set; }

        public decimal? PenaltyRate { get; set; }

        public decimal? RecoverableFees { get; set; }

        public decimal? NonRecoverableFees { get; set; }

        public Guid? BidId { get; set; }

        public Guid DelinquencyId { get; set; }
    }

    public class Result : ResultBase, IAuditEntity<Guid>, IEntity
    {
        public Bid Bid { get; set; }

        public Delinquency Delinquency { get; set; }

        #region IAuditEntity<Guid> implementation

        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
