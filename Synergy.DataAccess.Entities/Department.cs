namespace Synergy.DataAccess.Entities
{
    public class DepartmentBase : BaseAudit<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }

    public class Department : DepartmentBase, IAuditEntity<int>, IEntity
    {
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
    }
}
