using System;
using System.Collections.Generic;
using System.Text;

namespace Synergy.DataAccess.Entities
{
    public class PropertyChatAttachment : PropertyChatAttachmentBase, IAuditEntity<Guid>, IEntity
    {
        public PropertyChat PropertyChat { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
