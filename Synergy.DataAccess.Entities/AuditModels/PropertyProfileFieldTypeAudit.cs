using System;

namespace Synergy.DataAccess.Entities.AuditModels
{
    public class PropertyProfileFieldTypeAudit : PropertyProfileFieldTypeBase, IAuditModelFields
    {
        public DateTime InsertedOn { get; set; }

        public Guid InsertedBy { get; set; }

        public Guid OperationId { get; set; }
    }
}
