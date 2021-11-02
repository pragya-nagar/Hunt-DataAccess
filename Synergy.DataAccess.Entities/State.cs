using System.Collections.Generic;

namespace Synergy.DataAccess.Entities
{
    public abstract class StateBase : BaseAudit<int>
    {
        public string Abbreviation { get; set; }

        public string Name { get; set; }
    }

    public class State : StateBase, IAuditEntity<int>, IEntity
    {
        public List<StateTaxe> Taxes { get; set; }

        public IEnumerable<PropertyProfileState> PropertyProfileStates { get; set; }

        public List<County> Counties { get; set; }

        #region IAuditEntity<int> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
