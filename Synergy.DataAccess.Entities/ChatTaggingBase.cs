using System;
using System.Collections.Generic;
using System.Text;

namespace Synergy.DataAccess.Entities
{
    public  class ChatTaggingBase : BaseAudit<Guid>
    {
        public Guid ChatId { get; set; }

        public Guid TaggedUserId { get; set; }
    }
}
