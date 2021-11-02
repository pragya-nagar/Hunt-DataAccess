using System;
using Synergy.DataAccess.Entities.OpportunityEntities;

namespace Synergy.DataAccess.Entities
{
    public class Reminder : ReminderBase, IAuditEntity<Guid>, IEntity
    {
        public User User { get; set; }

        public Contact Contact { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
