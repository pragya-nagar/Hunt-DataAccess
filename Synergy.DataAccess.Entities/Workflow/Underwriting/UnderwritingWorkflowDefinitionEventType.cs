using System;

namespace Synergy.DataAccess.Entities
{
    public abstract class UnderwritingWorkflowDefinitionEventTypeBase : BaseAudit<Guid>
    {
        public int EventTypeId { get; set; }

        public Guid WorkflowDefinitionId { get; set; }
    }

    public class UnderwritingWorkflowDefinitionEventType : UnderwritingWorkflowDefinitionEventTypeBase, IAuditEntity<Guid>, IEntity
    {
        public EventType EventType { get; set; }

        public UnderwritingWorkflowDefinition WorkflowDefinition { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
