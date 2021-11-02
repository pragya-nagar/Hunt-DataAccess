using System;
using System.Collections.Generic;
using System.Text;

namespace Synergy.DataAccess.Entities.Processing
{
    public class LoanPropertyType : LoanPropertyTypeBase, IAuditEntity<int>, IEntity
    {
        public Loan Loan { get; set; }

        #region IAuditEntity<int> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
