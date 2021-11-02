using System;

namespace Synergy.DataAccess.Entities
{
    public class EventUserBase : BaseAudit<Guid>
    {
        public Guid EventId { get; set; }

        public Guid UserId { get; set; }

        public int DepartmentId { get; set; }
    }

    public class EventUser : EventUserBase, IAuditEntity<Guid>, IEntity
    {
        public Event Event { get; set; }

        public User User { get; set; }

        public Department Department { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
