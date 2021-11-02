using System;
using Synergy.DataAccess.Entities.OpportunityEntities;

namespace Synergy.DataAccess.Entities.AuditModels
{
    public class OpportunityBorrowerBaseAudit : OpportunityBorrowerBase, IAuditModelFields
    {
        public DateTime InsertedOn { get; set; }

        public Guid InsertedBy { get; set; }

        public Guid OperationId { get; set; }

        public string Discriminator { get; set; }

        // OpportunityBorrowerAudit fields
        public string SSN { get; set; }

        public bool? IsMarried { get; set; }

        public string DateOfBirth { get; set; }

        // OpportunityEntityBorrowerAudit fields
        public string EntityName { get; set; }

        public string TaxIdNumber { get; set; }

        public string Title { get; set; }
    }
}
