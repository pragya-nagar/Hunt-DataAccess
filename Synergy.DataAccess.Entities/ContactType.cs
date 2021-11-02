namespace Synergy.DataAccess.Entities
{
    public abstract class ContactTypeBase : BaseAudit<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }

    public class ContactType : ContactTypeBase, IAuditEntity<int>, IEntity
    {
        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
