using System;

namespace Synergy.DataAccess.Entities
{
    public abstract class TaskDefinitionUserBase : BaseAudit<Guid>
    {
        public Guid UserId { get; set; }

        public Guid TaskDefinitionId { get; set; }

        public Guid? OriginalId { get; set; }
    }

    public class TaskDefinitionUser : TaskDefinitionUserBase, IAuditEntity<Guid>, IEntity
    {
        public User User { get; set; }

        public TaskDefinition TaskDefinition { get; set; }

        #region IAuditEntity<Guid> implementation

        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }

        #endregion
    }
}
