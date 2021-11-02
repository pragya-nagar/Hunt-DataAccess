using System;
using Synergy.DataAccess.Entities.MailMerge;

namespace Synergy.DataAccess.Entities.AuditModels
{
    public class TemplateFileCountyAudit : TemplateFileCountyBase, IAuditModelFields
    {
        public DateTime InsertedOn { get; set; }

        public Guid InsertedBy { get; set; }

        public Guid OperationId { get; set; }
    }
}