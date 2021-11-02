using System;

namespace Synergy.DataAccess.Entities.OpportunityEntities
{
    public abstract class OpportunityBorrowerBase : BaseAudit<Guid>, IAuditEntity<Guid>, IEntity
    {
        public Guid OpportunityId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string Email { get; set; }

        public string CellPhone { get; set; }

        public string WorkPhone { get; set; }

        public string Fax { get; set; }

        public int Order { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
