using System;

namespace Synergy.DataAccess.Entities
{
    public abstract class BidBase : BaseAudit<Guid>
    {
        public string Number { get; set; }

        public string Entity { get; set; }

        public string Portfolio { get; set; }

        public Guid EventId { get; set; }
    }

    public class Bid : BidBase, IAuditEntity<Guid>, IEntity
    {
        public Event Event { get; set; }

        #region IAuditEntity<Guid> implementation

        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
