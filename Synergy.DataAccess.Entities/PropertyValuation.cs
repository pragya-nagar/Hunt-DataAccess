using System;

namespace Synergy.DataAccess.Entities
{
    public abstract class PropertyValuationBase : BaseAudit<Guid>
    {
        public Guid PropertyId { get; set; }

        public int AppraisedYear { get; set; }

        public decimal? LandValue { get; set; }

        public decimal? ImprovementValue { get; set; }

        public decimal? AppraisedValue { get; set; }

        public bool IsActive { get; set; }
    }

    public class PropertyValuation : PropertyValuationBase, IAuditEntity<Guid>, IEntity
    {
        public Property Property { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
