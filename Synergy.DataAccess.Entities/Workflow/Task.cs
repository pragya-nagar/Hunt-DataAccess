using System;
using System.Collections.Generic;

namespace Synergy.DataAccess.Entities
{
    public abstract class TaskBase : BaseAudit<Guid>
    {
        public Guid TaskDefinitionId { get; set; }

        public Guid WorkflowId { get; set; }

        public int InstanceNumber { get; set; }

        public DateTime? DueDate { get; set; }

        public int Status { get; set; }

        public int CompletionType { get; set; }

        public string Notes { get; set; }
    }

    public abstract class Task : TaskBase, IAuditEntity<Guid>, IEntity
    {
        public IEnumerable<TaskUser> Users { get; set; }

        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
    }
}