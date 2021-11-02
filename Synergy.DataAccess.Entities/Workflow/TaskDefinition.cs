using System;
using System.Collections.Generic;

namespace Synergy.DataAccess.Entities
{
    public abstract class TaskDefinitionBase : BaseAudit<Guid>
    {
        public string Name { get; set; }

        public bool IsActive { get; set; }

        public int TriggerDayOffset { get; set; }

        public int TriggerSourceTypeId { get; set; }

        public int? LogicTypeId { get; set; }

        public int NotificationType { get; set; }

        public Guid? OriginalId { get; set; }
    }

    public abstract class TaskDefinition : TaskDefinitionBase, IAuditEntity<Guid>, IEntity
    {
        public IEnumerable<TaskDefinitionUser> Users { get; set; }

        public IEnumerable<TaskDefinitionDepartment> Departments { get; set; }

        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
    }
}
