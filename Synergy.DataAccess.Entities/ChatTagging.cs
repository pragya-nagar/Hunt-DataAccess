using System;
using System.Collections.Generic;
using System.Text;

namespace Synergy.DataAccess.Entities
{
    public class ChatTagging : ChatTaggingBase, IAuditEntity<Guid>, IEntity
    {
        public PropertyChat PropertyChat { get; set; }

        public User User { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
