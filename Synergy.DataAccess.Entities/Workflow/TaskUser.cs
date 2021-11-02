using System;

namespace Synergy.DataAccess.Entities
{
    public abstract class TaskUserBase : BaseAudit<Guid>
    {
        public Guid TaskId { get; set; }

        public Guid UserId { get; set; }

        public DateTime? CompletedDate { get; set; }
    }

    public class TaskUser : TaskUserBase, IAuditEntity<Guid>, IEntity
    {
        public Task Task { get; set; }

        public User User { get; set; }

        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
    }
}