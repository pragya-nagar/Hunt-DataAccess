using System;

namespace Synergy.DataAccess.Abstractions.Models
{
    public abstract class AuditModel
    {
        public DateTime CreatedOn { get; set; }

        public FastEntityModel<Guid> CreatedBy { get; set; }

        public DateTime ModifiedOn { get; set; }

        public FastEntityModel<Guid> ModifiedBy { get; set; }
    }
}
