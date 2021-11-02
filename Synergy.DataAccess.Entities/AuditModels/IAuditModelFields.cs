using System;

namespace Synergy.DataAccess.Entities.AuditModels
{
    public interface IAuditModelFields
    {
        DateTime InsertedOn { get; set; }

        Guid InsertedBy { get; set; }

        Guid OperationId { get; set; }
    }
}
