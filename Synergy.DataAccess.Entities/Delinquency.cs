using System;
using System.Collections.Generic;

namespace Synergy.DataAccess.Entities
{
    public abstract class DelinquencyBase : BaseAudit<Guid>
    {
        public int DelinquencyTaxYear { get; set; }

        public Guid PropertyId { get; set; }

        public Guid? EventId { get; set; }

        public decimal Amount { get; set; }

        public decimal? RUAmount { get; set; }

        public decimal? RULTVPercent { get; set; }

        public decimal? LTVPercent { get; set; }

        public bool IsLoan { get; set; }
    }

    public class Delinquency : DelinquencyBase, IAuditEntity<Guid>, IEntity
    {
        public Property Property { get; set; }

        public PropertySupplementalEventData PropertySupplementalEventData { get; set; }

        public Event Event { get; set; }

        public IEnumerable<Result> Results { get; set; }

        public IEnumerable<EventDataCutDecision> EventDataCutDecisions { get; set; }

        public IEnumerable<CollectingEntity> CollectingEntities { get; set; }

        public IEnumerable<Decision> Decisions { get; set; }

        public IEnumerable<DelinquencyPropertyDisplayStrategy> DelinquencyPropertyDisplayStrategy { get; set; }

        public IEnumerable<DelinquencyPropertyScoring> DelinquencyPropertyScorings { get; set; }

        public IEnumerable<DelinquencyComment> DelinquencyComment { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
