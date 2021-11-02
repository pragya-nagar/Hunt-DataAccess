using System;
using System.Collections.Generic;
using System.Text;

namespace Synergy.DataAccess.Entities
{
    public  class PropertyChatAttachmentBase : BaseAudit<Guid>
    {
        public Guid ChatId { get; set; }

        public string AttachmentFileName { get; set; }
    }
}
