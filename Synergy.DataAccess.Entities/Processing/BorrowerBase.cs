using System;

namespace Synergy.DataAccess.Entities.Processing
{
    public class BorrowerBase : BaseAudit<Guid>
    {
        public Guid LoanId { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string SocialSecurityNumber { get; set; }

        public string HomePhone { get; set; }

        public string WorkPhone { get; set; }

        public string CellPhone { get; set; }

        public string Email { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public bool? Married { get; set; }
    }
}
