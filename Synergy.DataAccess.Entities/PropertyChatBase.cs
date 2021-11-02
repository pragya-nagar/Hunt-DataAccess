using System;
using System.Collections.Generic;
using System.Text;

namespace Synergy.DataAccess.Entities
{
    public class PropertyChatBase : BaseAudit<Guid>
    {
        public Guid PropertyId { get; set; }

        public Guid UserId { get; set; }

        public string ChatMessage { get; set; }
    }
}