namespace Synergy.DataAccess.Entities
{
    public abstract class StateTaxeBase : BaseAudit<int>
    {
        public int StateId { get; set; }

        public decimal TaxRate { get; set; }
    }

    public class StateTaxe : StateTaxeBase, IAuditEntity<int>, IEntity
    {
        public State State { get; set; }

        #region IAuditEntity<int> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
