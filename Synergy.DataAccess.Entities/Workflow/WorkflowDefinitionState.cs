using System;

namespace Synergy.DataAccess.Entities
{
    public abstract class WorkflowDefinitionStateBase : BaseAudit<Guid>
    {
        public int StateId { get; set; }

        public Guid WorkflowDefinitionId { get; set; }
    }

    public abstract class WorkflowDefinitionState : WorkflowDefinitionStateBase, IAuditEntity<Guid>, IEntity
    {
        public State State { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}