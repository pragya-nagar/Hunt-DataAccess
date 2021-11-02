using System;
using System.Collections.Generic;
using System.Text;

namespace Synergy.DataAccess.Entities.Processing
{
    public class LoanStage : LoanStageBase, IAuditEntity<int>, IEntity
    {
        #region IAuditEntity<int> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
