using System;

namespace Synergy.DataAccess.Entities
{
    public abstract class OperationStatusBase : BaseAudit<Guid>
    {
        public int Code { get; set; }

        public int? Progress { get; set; }

        public string Message { get; set; }
    }

    public class OperationStatus : OperationStatusBase, IAuditEntity<Guid>, IEntity
    {
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
    }
}
