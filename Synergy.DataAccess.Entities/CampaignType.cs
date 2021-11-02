using System.Collections.Generic;

namespace Synergy.DataAccess.Entities
{
    public abstract class CampaignTypeBase : BaseAudit<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int? ParentTypeId { get; set; }
    }

    public class CampaignType : CampaignTypeBase, IAuditEntity<int>, IEntity
    {
        public CampaignType ParentType { get; set; }

        public List<CampaignType> ChaildTypes { get; set; }

        #region IAuditEntity<int> implementation

        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
