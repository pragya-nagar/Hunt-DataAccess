using System;

namespace Synergy.DataAccess.Entities
{
    public abstract class TaskDefinitionDepartmentBase : BaseAudit<Guid>
    {
        public int DepartmentId { get; set; }

        public Guid TaskDefinitionId { get; set; }

        public Guid? OriginalId { get; set; }
    }

    public class TaskDefinitionDepartment : TaskDefinitionDepartmentBase, IAuditEntity<Guid>, IEntity
    {
        public Department Department { get; set; }

        public TaskDefinition TaskDefinition { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
