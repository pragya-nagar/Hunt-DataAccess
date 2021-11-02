namespace Synergy.DataAccess.Entities
{
    public class CountyBase : BaseAudit<int>
    {
        public int StateId { get; set; }

        public string Name { get; set; }
    }

    public class County : CountyBase, IEntity, IAuditEntity<int>
    {
        public State State { get; set; }

        #region IAuditEntity<int> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
