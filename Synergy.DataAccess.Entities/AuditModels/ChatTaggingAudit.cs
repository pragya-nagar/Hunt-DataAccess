using System;
using System.Collections.Generic;
using System.Text;

namespace Synergy.DataAccess.Entities.AuditModels
{
    public class ChatTaggingAudit : ChatTaggingBase, IAuditModelFields
    {
        public DateTime InsertedOn { get; set; }

        public Guid InsertedBy { get; set; }

        public Guid OperationId { get; set; }
    }
}
