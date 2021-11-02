using System;

namespace Synergy.DataAccess.Entities
{
    public abstract class DecisionBase : BaseAudit<Guid>
    {
        public string Comment { get; set; }

        public Guid UserId { get; set; }

        public Guid DelinquencyId { get; set; }

        public Guid EventDecisionLevelId { get; set; }

        public int? DecisionTypeId { get; set; }

        public DateTime? DecisionDate { get; set; }

        public Guid? PropertyProfileId { get; set; }
    }

    public class Decision : DecisionBase, IAuditEntity<Guid>, IEntity
    {
        public User User { get; set; }

        public Delinquency Delinquency { get; set; }

        public EventDecisionLevel EventDecisionLevel { get; set; }

        public DecisionType DecisionType { get; set; }

        public PropertyProfile PropertyProfile { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
