using System.Collections.Generic;

namespace Synergy.DataAccess.Entities
{
    public abstract class CampaignFieldTypeBase : BaseAudit<int>
    {
        public string Name { get; set; }
    }

    public class CampaignFieldType : CampaignFieldTypeBase, IAuditEntity<int>, IEntity
    {
        public IEnumerable<CampaignLogicType> CampaignLogicTypes { get; set; }

        #region IAuditEntity<int> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
