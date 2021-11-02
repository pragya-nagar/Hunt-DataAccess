using System;

namespace Synergy.DataAccess.Entities.Processing
{
    public class EntityBorrowerBase : BaseAudit<Guid>
    {
        public Guid LoanId { get; set; }

        public string EntityName { get; set; }

        public string TaxID { get; set; }

        public string ContactPerson { get; set; }

        public string Email { get; set; }

        public string OfficePhone { get; set; }

        public string CellPhone { get; set; }

        public string AuthorizedOfficerName { get; set; }

        public string AuthorizedOfficerTitle { get; set; }
    }
}
