using System;

namespace Synergy.DataAccess.Entities
{
    public abstract class DelinquencyPropertyScoringBase : BaseAudit<Guid>
    {
        public Guid DelinquencyId { get; set; }

        public int? PropertyScoring { get; set; }
    }

    public class DelinquencyPropertyScoring : DelinquencyPropertyScoringBase, IAuditEntity<Guid>, IEntity
    {
        public Delinquency Delinquency { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
