using System;
using System.Collections.Generic;
using System.Text;

namespace Synergy.DataAccess.Entities
{
    public class PropertyChat : PropertyChatBase, IAuditEntity<Guid>, IEntity
    {
        public Property Property { get; set; }

        public User User { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}